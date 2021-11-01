
namespace Thi_KTLT_WF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.i_gt = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.j_gt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NhapNPanel = new System.Windows.Forms.Panel();
            this.n = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.n_gt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fileBtn = new System.Windows.Forms.RadioButton();
            this.randBtn = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NhapNPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(173, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC HÀM XỬ LÝ MẢNG 2 CHIỀU TRÊN C#";
            this.toolTip1.SetToolTip(this.label1, "Author by Vũ Đạt");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách các bài: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtConsole);
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 247);
            this.panel1.TabIndex = 2;
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(-2, -2);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(798, 247);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.WordWrap = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "1. Xuat cac phan tu cuc tri cua ma tran",
            "2. Sap xep ma tran: cac cot le tang, chan giam",
            "3. Sap xep cho cac DC song DCC va DCC tang dan",
            "4. Kiem tra cac gia tri co giam dan theo tung cot",
            "5. Liet ke chi so cac dong chua toan gia tri chan",
            "6. Xuat cac duong cheo song song DCC",
            "7. Tim cac gia tri xuat hien nhieu nhat",
            "8. Tim cac chu so xuat hien nhieu nhat",
            "9. Xuat cac duong cheo song song DCP",
            "10.Hoan vi hai cot i va j"});
            this.listBox1.Location = new System.Drawing.Point(201, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(207, 221);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 38);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Chạy";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // i_gt
            // 
            this.i_gt.Location = new System.Drawing.Point(44, 29);
            this.i_gt.Name = "i_gt";
            this.i_gt.Size = new System.Drawing.Size(117, 22);
            this.i_gt.TabIndex = 6;
            this.i_gt.Text = "0";
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.j_gt);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.i_gt);
            this.panelInput.Location = new System.Drawing.Point(22, 28);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(190, 105);
            this.panelInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "j";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "i";
            // 
            // j_gt
            // 
            this.j_gt.Location = new System.Drawing.Point(44, 57);
            this.j_gt.Name = "j_gt";
            this.j_gt.Size = new System.Drawing.Size(117, 22);
            this.j_gt.TabIndex = 8;
            this.j_gt.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập giá trị";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.NhapNPanel);
            this.panel2.Controls.Add(this.panelInput);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(545, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 162);
            this.panel2.TabIndex = 8;
            // 
            // NhapNPanel
            // 
            this.NhapNPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NhapNPanel.Controls.Add(this.n);
            this.NhapNPanel.Controls.Add(this.label9);
            this.NhapNPanel.Controls.Add(this.n_gt);
            this.NhapNPanel.Location = new System.Drawing.Point(23, 28);
            this.NhapNPanel.Name = "NhapNPanel";
            this.NhapNPanel.Size = new System.Drawing.Size(190, 105);
            this.NhapNPanel.TabIndex = 16;
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(17, 28);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(16, 18);
            this.n.TabIndex = 9;
            this.n.Text = "n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nhập giá trị";
            // 
            // n_gt
            // 
            this.n_gt.Location = new System.Drawing.Point(43, 28);
            this.n_gt.Name = "n_gt";
            this.n_gt.Size = new System.Drawing.Size(101, 22);
            this.n_gt.TabIndex = 6;
            this.n_gt.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(324, 221);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(95, 38);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.Text = "Tải lại trang";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(440, 221);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(96, 38);
            this.endBtn.TabIndex = 10;
            this.endBtn.Text = "Thoát";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Màn hình Console";
            // 
            // fileBtn
            // 
            this.fileBtn.AutoSize = true;
            this.fileBtn.Location = new System.Drawing.Point(4, 29);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(133, 21);
            this.fileBtn.TabIndex = 13;
            this.fileBtn.TabStop = true;
            this.fileBtn.Text = "Nhập data từ file";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.CheckedChanged += new System.EventHandler(this.fileBtn_CheckedChanged);
            // 
            // randBtn
            // 
            this.randBtn.AutoSize = true;
            this.randBtn.Location = new System.Drawing.Point(4, 3);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(170, 21);
            this.randBtn.TabIndex = 14;
            this.randBtn.TabStop = true;
            this.randBtn.Text = "Nhập data ngẫu nhiên";
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.CheckedChanged += new System.EventHandler(this.randBtn_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.randBtn);
            this.panel3.Controls.Add(this.fileBtn);
            this.panel3.Location = new System.Drawing.Point(8, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 61);
            this.panel3.TabIndex = 15;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Chương Trình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nhóm 13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.NhapNPanel.ResumeLayout(false);
            this.NhapNPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox i_gt;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox j_gt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton randBtn;
        private System.Windows.Forms.RadioButton fileBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel NhapNPanel;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox n_gt;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

