namespace Jusolink.Example.csharp
{
    partial class searchExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.zipcode = new System.Windows.Forms.ColumnHeader();
            this.sectionNum = new System.Windows.Forms.ColumnHeader();
            this.roadAddr1 = new System.Windows.Forms.ColumnHeader();
            this.roadAddr2 = new System.Windows.Forms.ColumnHeader();
            this.jibunAddr = new System.Windows.Forms.ColumnHeader();
            this.relatedJibun = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPage = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuggestIndex = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.txtNextPage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주소검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(20, 26);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(272, 21);
            this.txtIndex.TabIndex = 0;
            this.txtIndex.Text = "서울특별시 강남구 상성동 159";
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            this.txtIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIndex_KeyDown);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zipcode,
            this.sectionNum,
            this.roadAddr1,
            this.roadAddr2,
            this.jibunAddr,
            this.relatedJibun});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1006, 450);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // zipcode
            // 
            this.zipcode.Text = "우편번호";
            this.zipcode.Width = 70;
            // 
            // sectionNum
            // 
            this.sectionNum.Text = "새우편번호";
            this.sectionNum.Width = 80;
            // 
            // roadAddr1
            // 
            this.roadAddr1.Text = "도로명주소";
            this.roadAddr1.Width = 290;
            // 
            // roadAddr2
            // 
            this.roadAddr2.Text = "참고항목";
            this.roadAddr2.Width = 100;
            // 
            // jibunAddr
            // 
            this.jibunAddr.Text = "지번주소";
            this.jibunAddr.Width = 290;
            // 
            // relatedJibun
            // 
            this.relatedJibun.Text = "관련지번목록";
            this.relatedJibun.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "> 검색어를 검색하고 원하는 주소정보 셀을 선택합니다.";
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.AutoSize = true;
            this.txtCurrentPage.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCurrentPage.Location = new System.Drawing.Point(489, 554);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(0, 21);
            this.txtCurrentPage.TabIndex = 3;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.AutoSize = true;
            this.txtTotalPage.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotalPage.Location = new System.Drawing.Point(534, 554);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(0, 21);
            this.txtTotalPage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(513, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // txtSuggestIndex
            // 
            this.txtSuggestIndex.AutoSize = true;
            this.txtSuggestIndex.Font = new System.Drawing.Font("굴림", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSuggestIndex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSuggestIndex.Location = new System.Drawing.Point(416, 51);
            this.txtSuggestIndex.Name = "txtSuggestIndex";
            this.txtSuggestIndex.Size = new System.Drawing.Size(0, 13);
            this.txtSuggestIndex.TabIndex = 6;
            this.txtSuggestIndex.Click += new System.EventHandler(this.txtSuggestIndex_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(378, 551);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(93, 26);
            this.btnPrevPage.TabIndex = 7;
            this.btnPrevPage.Text = "이전 페이지";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // txtNextPage
            // 
            this.txtNextPage.Location = new System.Drawing.Point(574, 550);
            this.txtNextPage.Name = "txtNextPage";
            this.txtNextPage.Size = new System.Drawing.Size(93, 26);
            this.txtNextPage.TabIndex = 8;
            this.txtNextPage.Text = "다음 페이지";
            this.txtNextPage.UseVisualStyleBackColor = true;
            this.txtNextPage.Click += new System.EventHandler(this.txtNextPage_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 593);
            this.Controls.Add(this.txtNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.txtSuggestIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주소정보 검색";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader zipcode;
        private System.Windows.Forms.ColumnHeader sectionNum;
        private System.Windows.Forms.ColumnHeader roadAddr1;
        private System.Windows.Forms.ColumnHeader roadAddr2;
        private System.Windows.Forms.ColumnHeader jibunAddr;
        private System.Windows.Forms.ColumnHeader relatedJibun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCurrentPage;
        private System.Windows.Forms.Label txtTotalPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSuggestIndex;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button txtNextPage;
    }
}