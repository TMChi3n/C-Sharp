namespace QuanLyThongTin
{
    partial class frmGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGV));
            dgViewGV = new DataGridView();
            cboLop = new ComboBox();
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            cboKhoa = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgViewGV).BeginInit();
            SuspendLayout();
            // 
            // dgViewGV
            // 
            dgViewGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgViewGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewGV.Location = new Point(292, 98);
            dgViewGV.Name = "dgViewGV";
            dgViewGV.RowHeadersWidth = 51;
            dgViewGV.RowTemplate.Height = 29;
            dgViewGV.Size = new Size(803, 272);
            dgViewGV.TabIndex = 0;
            dgViewGV.CellContentClick += dgViewGV_CellContentClick;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(68, 98);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(177, 28);
            cboLop.TabIndex = 7;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 98);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "Lớp";
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 51);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "Khoa";
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(68, 152);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(177, 28);
            cboKhoa.TabIndex = 7;
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(411, 23);
            label3.Name = "label3";
            label3.Size = new Size(248, 29);
            label3.TabIndex = 9;
            label3.Text = "Thông tin giáo viên";
            // 
            // frmGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 372);
            Controls.Add(label3);
            Controls.Add(cboKhoa);
            Controls.Add(cboLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgViewGV);
            Name = "frmGV";
            Text = "Thông tin giáo viên";
            ((System.ComponentModel.ISupportInitialize)dgViewGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViewGV;
        private ComboBox cboLop;
        private Label label1;
        private Button btnBack;
        private Label label2;
        private ComboBox cboKhoa;
        private Label label3;
    }
}