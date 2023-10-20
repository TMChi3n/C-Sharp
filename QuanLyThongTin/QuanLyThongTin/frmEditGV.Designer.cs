namespace QuanLyThongTin
{
    partial class frmEditGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditGV));
            cboKhoaGV = new ComboBox();
            btnUpdateGV = new Button();
            btnBack = new Button();
            btnDeleteGV = new Button();
            btnAddGV = new Button();
            txtGenderGV = new TextBox();
            txtNameGV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtAddressGV = new TextBox();
            cboLopGV = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cboKhoaGV
            // 
            cboKhoaGV.FormattingEnabled = true;
            cboKhoaGV.Location = new Point(144, 92);
            cboKhoaGV.Name = "cboKhoaGV";
            cboKhoaGV.Size = new Size(344, 28);
            cboKhoaGV.TabIndex = 15;
            // 
            // btnUpdateGV
            // 
            btnUpdateGV.Location = new Point(207, 292);
            btnUpdateGV.Name = "btnUpdateGV";
            btnUpdateGV.Size = new Size(120, 56);
            btnUpdateGV.TabIndex = 11;
            btnUpdateGV.Text = "Cập nhật";
            btnUpdateGV.UseVisualStyleBackColor = true;
            btnUpdateGV.Click += btnUpdateGV_Click;
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(532, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 56);
            btnBack.TabIndex = 12;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteGV
            // 
            btnDeleteGV.Location = new Point(369, 292);
            btnDeleteGV.Name = "btnDeleteGV";
            btnDeleteGV.Size = new Size(120, 56);
            btnDeleteGV.TabIndex = 13;
            btnDeleteGV.Text = "Xóa";
            btnDeleteGV.UseVisualStyleBackColor = true;
            btnDeleteGV.Click += btnDeleteGV_Click;
            // 
            // btnAddGV
            // 
            btnAddGV.Location = new Point(43, 292);
            btnAddGV.Name = "btnAddGV";
            btnAddGV.Size = new Size(120, 56);
            btnAddGV.TabIndex = 14;
            btnAddGV.Text = "Thêm";
            btnAddGV.UseVisualStyleBackColor = true;
            btnAddGV.Click += btnAddGV_Click;
            // 
            // txtGenderGV
            // 
            txtGenderGV.Location = new Point(144, 176);
            txtGenderGV.Name = "txtGenderGV";
            txtGenderGV.Size = new Size(344, 27);
            txtGenderGV.TabIndex = 9;
            // 
            // txtNameGV
            // 
            txtNameGV.AcceptsReturn = true;
            txtNameGV.Location = new Point(144, 52);
            txtNameGV.Name = "txtNameGV";
            txtNameGV.Size = new Size(344, 27);
            txtNameGV.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 222);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 183);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "Khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên giáo viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 138);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 6;
            label5.Text = "Lớp";
            // 
            // txtAddressGV
            // 
            txtAddressGV.Location = new Point(144, 219);
            txtAddressGV.Name = "txtAddressGV";
            txtAddressGV.Size = new Size(344, 27);
            txtAddressGV.TabIndex = 9;
            // 
            // cboLopGV
            // 
            cboLopGV.FormattingEnabled = true;
            cboLopGV.Location = new Point(144, 135);
            cboLopGV.Name = "cboLopGV";
            cboLopGV.Size = new Size(344, 28);
            cboLopGV.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(532, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 62);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEditGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 453);
            Controls.Add(btnSave);
            Controls.Add(cboLopGV);
            Controls.Add(cboKhoaGV);
            Controls.Add(btnUpdateGV);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteGV);
            Controls.Add(btnAddGV);
            Controls.Add(txtAddressGV);
            Controls.Add(txtGenderGV);
            Controls.Add(txtNameGV);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditGV";
            Text = "Cập nhật thông tin giáo viên";
            Load += frmEditGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboKhoaGV;
        private Button btnUpdateGV;
        private Button btnBack;
        private Button btnDeleteGV;
        private Button btnAddGV;
        private TextBox txtGenderGV;
        private TextBox txtNameGV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtAddressGV;
        private ComboBox cboLopGV;
        private Button btnSave;
    }
}