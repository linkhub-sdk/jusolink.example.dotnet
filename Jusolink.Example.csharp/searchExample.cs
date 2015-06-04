using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jusolink.Example.csharp
{
    public partial class searchExample : Form
    {
        // 링크아이디
        private string LinkID = "TESTER_JUSO";

        // 비밀키
        private string SecretKey = "FjaRgAfVUPvSDHTrdd/uw/dt/Cdo3GgSFKyE1+NQ+bc=";

        private JusolinkService jusolinkService;

        private int? pageNum = 1;    // 페이지번호
        private int? totalPage;      // 전체 페이지수
        private string suggestIndex; // 수정제시어

        public searchExample()
        {
            InitializeComponent();

            jusolinkService = new JusolinkService(LinkID, SecretKey);

            // listview height 조정을 위한 imageList 추가 
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            listView1.SmallImageList = imgList;
            this.ActiveControl = txtIndex;
        }

        // 주소검색
        private void btnSearch_Click(object sender, EventArgs e)
        {   
            int perPage = 20;           // 페이지당 목록 갯수, 최대 100개
            bool noSuggest = false;     // 수정제시어 끄기
            bool noDiffer = false;      // 차등검색 끄기

            try
            {
                SearchResult jusoInfo = jusolinkService.search(txtIndex.Text, pageNum, perPage, noSuggest, noDiffer);

                listView1.Items.Clear();            //listview 초기화
                pageNum = jusoInfo.page;            // 페이지 번호
                totalPage = jusoInfo.totalPage;     // 전체 페이지 수 

                txtCurrentPage.Text = jusoInfo.page.ToString();
                txtTotalPage.Text = jusoInfo.totalPage.ToString();

                if (jusoInfo.suggest != null)
                {
                    suggestIndex = jusoInfo.suggest;    // 수정제시어 

                    txtSuggestIndex.Text = "수정제시어 : [" + jusoInfo.suggest + "] 검색결과 보기";
                }
                else
                {
                    txtSuggestIndex.Text = "";
                }


                if (jusoInfo.juso != null)
                {
                    for (int i = 0; i < jusoInfo.juso.Count; i++)
                    {
                        listView1.Items.Add(jusoInfo.juso[i].zipcode, 1);       // 우편번호
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].sectionNum);   // 새우편번호
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr1);    // 도로명주소
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr2);    // 도로명주소(참고항목)
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].jibunAddr);    // 지번주소

                        if (jusoInfo.juso[i].relatedJibun != null)
                        {
                            string relatedJibun = "";       // 관련지번 목록

                            for (int j = 0; j < jusoInfo.juso[i].relatedJibun.Count; j++)
                            {

                                relatedJibun += jusoInfo.juso[i].relatedJibun[j] + ' ';
                            }
                            listView1.Items[i].SubItems.Add(relatedJibun);  // 관련지번
                        }
                    }
                }
                else
                {
                    MessageBox.Show("검색된 주소정보가 없습니다");
                }
                
            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

                listView1.Items.Clear();
            }
            finally
            {
                this.ActiveControl = txtIndex;
            }
        }


        // 수정제시어 검색
        private void txtSuggestIndex_Click(object sender, EventArgs e)
        {
            if (suggestIndex != null && suggestIndex != "")
            {
                pageNum = 1;
                txtIndex.Text = suggestIndex;
                btnSearch.PerformClick();
            }
        }

        // 이전페이지
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum = pageNum - 1;
                btnSearch.PerformClick();
            }
        }

        // 다음페이지
        private void txtNextPage_Click(object sender, EventArgs e)
        {
            if (pageNum < totalPage)
            {
                pageNum = pageNum + 1;
                btnSearch.PerformClick();
            }
        }
        
        // 주소정보 선택
        private void listView1_Click(object sender, EventArgs e)
        {
            JusoInfo selectedJuso = new JusoInfo();

            selectedJuso.zipcode = listView1.SelectedItems[0].Text;                   // 우편번호
            selectedJuso.sectionNum = listView1.SelectedItems[0].SubItems[1].Text;    // 새우편번호
            selectedJuso.roadaddr1 = listView1.SelectedItems[0].SubItems[2].Text;     // 도로명주소
            selectedJuso.roadaddr2 = listView1.SelectedItems[0].SubItems[3].Text;     // 도로명주소 참고항목
            selectedJuso.jibunaddr = listView1.SelectedItems[0].SubItems[4].Text;     // 지번주소

            this.Dispose();

            // 상세주소입력 dialog 호출
            searchDetail detailForm = new searchDetail(selectedJuso);

            detailForm.ShowDialog();
        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            pageNum = 1;
        }
        
        private void txtIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }

    // 주소정보 폼 전달을 위한 Structure 선언
    public struct JusoInfo
    {
        public string zipcode;
        public string sectionNum;
        public string roadaddr1;
        public string roadaddr2;
        public string jibunaddr;
    }
}
