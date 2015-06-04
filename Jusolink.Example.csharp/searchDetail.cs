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
    public partial class searchDetail : Form
    {
        private string roadaddr1;
        private string roadaddr2;

        public searchDetail(JusoInfo selectedJuso)
        {
            InitializeComponent();

            //도로명주소 정보
            txtRoadZipcode.Text = selectedJuso.zipcode;         // 우편번호
            txtRoadSectionNum.Text = selectedJuso.sectionNum;   // 새우편번호
            txtRoadAddr.Text = selectedJuso.roadaddr1 + ' ' + selectedJuso.roadaddr2;   // 도로명주소
            roadaddr1 = selectedJuso.roadaddr1;
            roadaddr2 = selectedJuso.roadaddr2;

            //지번주소정보
            txtJibunZipcode.Text = selectedJuso.zipcode;
            txtJibunSectionNum.Text = selectedJuso.sectionNum;
            txtJibunAddr.Text = selectedJuso.jibunaddr;     // 지번주소

            rbRoad.Checked = true;
            this.ActiveControl = txtRoadDetail;
        }

        // 다시검색
        private void btnResearch_Click(object sender, EventArgs e)
        {
            this.Dispose();
            searchExample searchForm = new searchExample();
            searchForm.ShowDialog();
        }

        // 확인
        private void btnOk_Click(object sender, EventArgs e)
        {
            jusolinkExample.g_zipcode = txtRoadZipcode.Text;
            jusolinkExample.g_sectionNum = txtRoadSectionNum.Text;

            if (rbRoad.Checked)
            {
                // 표준화도로명 주소
                jusolinkExample.g_address = roadaddr1 + ", " + txtRoadDetail.Text + " " + roadaddr2;
            }
            else
            {
                // 표준화지번 주소
                jusolinkExample.g_address = txtJibunAddr.Text + ", " + txtJibunDetail.Text;
            }
            this.Dispose();
        }

        private void rbJibun_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtJibunDetail;
        }

        private void rbRoad_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtRoadDetail;
        }

        private void txtJibunDetail_Click(object sender, EventArgs e)
        {
            rbJibun.Checked = true;
        }

        private void txtRoadDetail_Click(object sender, EventArgs e)
        {
            rbRoad.Checked = true;
        }

        private void txtRoadDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        private void txtJibunDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        private void txtJibunDetail_Enter(object sender, EventArgs e)
        {
            rbRoad.Checked = false;
            rbJibun.Checked = true;
        }

        private void txtRoadDetail_Enter(object sender, EventArgs e)
        {
            rbJibun.Checked = false;
            rbRoad.Checked = true;
        }
    }
}
