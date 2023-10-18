namespace QuanLyThongTin
{
    partial class frmHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHS));
            label1 = new Label();
            cboLop = new ComboBox();
            dgViewHS = new DataGridView();
            btnBack = new Button();
            btnAddHS = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewHS).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(65, 98);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(177, 28);
            cboLop.TabIndex = 1;
            // 
            // dgViewHS
            // 
            dgViewHS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgViewHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewHS.Location = new Point(292, 98);
            dgViewHS.Name = "dgViewHS";
            dgViewHS.RowHeadersWidth = 51;
            dgViewHS.RowTemplate.Height = 29;
            dgViewHS.Size = new Size(584, 263);
            dgViewHS.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 51);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddHS
            // 
            btnAddHS.Location = new Point(695, 51);
            btnAddHS.Name = "btnAddHS";
            btnAddHS.Size = new Size(169, 41);
            btnAddHS.TabIndex = 5;
            btnAddHS.Text = "Chỉnh sửa thông tin";
            btnAddHS.UseVisualStyleBackColor = true;
            btnAddHS.Click += btnAddHS_Click;
            // 
            // frmHS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 363);
            Controls.Add(cboLop);
            Controls.Add(btnAddHS);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgViewHS);
            Name = "frmHS";
            Text = "Thông tin học sinh";
            ((System.ComponentModel.ISupportInitialize)dgViewHS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboLop;
        private DataGridView dgViewHS;
        private Button btnBack;
        private Button btnAddHS;
    }
}