namespace Jusolink.Example.csharp
{
    partial class searchDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.rbJibun = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoadDetail = new System.Windows.Forms.TextBox();
            this.txtRoadAddr = new System.Windows.Forms.Label();
            this.txtRoadSectionNum = new System.Windows.Forms.Label();
            this.txtRoadZipcode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJibunDetail = new System.Windows.Forms.TextBox();
            this.txtJibunAddr = new System.Windows.Forms.Label();
            this.txtJibunSectionNum = new System.Windows.Forms.Label();
            this.txtJibunZipcode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "* 아래의 주소를 확인하시고 표준화 주소타입을 선택한 후 확인버튼을 누르세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "* 정확한 우편물 발송을 위해 표준화 도로명주소 사용을 권장합니다.";
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(26, 74);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(123, 16);
            this.rbRoad.TabIndex = 2;
            this.rbRoad.TabStop = true;
            this.rbRoad.Text = "표준화 도로명주소";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged);
            // 
            // rbJibun
            // 
            this.rbJibun.AutoSize = true;
            this.rbJibun.Location = new System.Drawing.Point(467, 74);
            this.rbJibun.Name = "rbJibun";
            this.rbJibun.Size = new System.Drawing.Size(111, 16);
            this.rbJibun.TabIndex = 3;
            this.rbJibun.TabStop = true;
            this.rbJibun.Text = "표준화 지번주소";
            this.rbJibun.UseVisualStyleBackColor = true;
            this.rbJibun.CheckedChanged += new System.EventHandler(this.rbJibun_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoadDetail);
            this.groupBox1.Controls.Add(this.txtRoadAddr);
            this.groupBox1.Controls.Add(this.txtRoadSectionNum);
            this.groupBox1.Controls.Add(this.txtRoadZipcode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtRoadDetail
            // 
            this.txtRoadDetail.Location = new System.Drawing.Point(87, 80);
            this.txtRoadDetail.Name = "txtRoadDetail";
            this.txtRoadDetail.Size = new System.Drawing.Size(306, 21);
            this.txtRoadDetail.TabIndex = 7;
            this.txtRoadDetail.Click += new System.EventHandler(this.txtRoadDetail_Click);
            this.txtRoadDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoadDetail_KeyDown);
            this.txtRoadDetail.Enter += new System.EventHandler(this.txtRoadDetail_Enter);
            // 
            // txtRoadAddr
            // 
            this.txtRoadAddr.Location = new System.Drawing.Point(85, 43);
            this.txtRoadAddr.Name = "txtRoadAddr";
            this.txtRoadAddr.Size = new System.Drawing.Size(307, 30);
            this.txtRoadAddr.TabIndex = 6;
            // 
            // txtRoadSectionNum
            // 
            this.txtRoadSectionNum.AutoSize = true;
            this.txtRoadSectionNum.Location = new System.Drawing.Point(283, 22);
            this.txtRoadSectionNum.Name = "txtRoadSectionNum";
            this.txtRoadSectionNum.Size = new System.Drawing.Size(0, 12);
            this.txtRoadSectionNum.TabIndex = 5;
            // 
            // txtRoadZipcode
            // 
            this.txtRoadZipcode.AutoSize = true;
            this.txtRoadZipcode.Location = new System.Drawing.Point(96, 22);
            this.txtRoadZipcode.Name = "txtRoadZipcode";
            this.txtRoadZipcode.Size = new System.Drawing.Size(0, 12);
            this.txtRoadZipcode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "상세주소 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "기본주소 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "새우편번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "구우편번호 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJibunDetail);
            this.groupBox2.Controls.Add(this.txtJibunAddr);
            this.groupBox2.Controls.Add(this.txtJibunSectionNum);
            this.groupBox2.Controls.Add(this.txtJibunZipcode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(467, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtJibunDetail
            // 
            this.txtJibunDetail.Location = new System.Drawing.Point(87, 80);
            this.txtJibunDetail.Name = "txtJibunDetail";
            this.txtJibunDetail.Size = new System.Drawing.Size(306, 21);
            this.txtJibunDetail.TabIndex = 7;
            this.txtJibunDetail.Click += new System.EventHandler(this.txtJibunDetail_Click);
            this.txtJibunDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJibunDetail_KeyDown);
            this.txtJibunDetail.Enter += new System.EventHandler(this.txtJibunDetail_Enter);
            // 
            // txtJibunAddr
            // 
            this.txtJibunAddr.Location = new System.Drawing.Point(85, 43);
            this.txtJibunAddr.Name = "txtJibunAddr";
            this.txtJibunAddr.Size = new System.Drawing.Size(307, 30);
            this.txtJibunAddr.TabIndex = 6;
            // 
            // txtJibunSectionNum
            // 
            this.txtJibunSectionNum.AutoSize = true;
            this.txtJibunSectionNum.Location = new System.Drawing.Point(283, 22);
            this.txtJibunSectionNum.Name = "txtJibunSectionNum";
            this.txtJibunSectionNum.Size = new System.Drawing.Size(0, 12);
            this.txtJibunSectionNum.TabIndex = 5;
            // 
            // txtJibunZipcode
            // 
            this.txtJibunZipcode.AutoSize = true;
            this.txtJibunZipcode.Location = new System.Drawing.Point(96, 22);
            this.txtJibunZipcode.Name = "txtJibunZipcode";
            this.txtJibunZipcode.Size = new System.Drawing.Size(0, 12);
            this.txtJibunZipcode.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "상세주소 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "기본주소 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "새우편번호 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "구우편번호 :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(366, 223);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(460, 223);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(80, 30);
            this.btnResearch.TabIndex = 10;
            this.btnResearch.Text = "다시검색";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // searchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 268);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbJibun);
            this.Controls.Add(this.rbRoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "searchDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상세주소 입력";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRoad;
        private System.Windows.Forms.RadioButton rbJibun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtRoadAddr;
        private System.Windows.Forms.Label txtRoadSectionNum;
        private System.Windows.Forms.Label txtRoadZipcode;
        private System.Windows.Forms.TextBox txtRoadDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJibunDetail;
        private System.Windows.Forms.Label txtJibunAddr;
        private System.Windows.Forms.Label txtJibunSectionNum;
        private System.Windows.Forms.Label txtJibunZipcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnResearch;
    }
}