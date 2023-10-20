namespace QuanLyThongTin
{
    partial class frmEditHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditHS));
            label1 = new Label();
            btnAddHS = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNameHS = new TextBox();
            txtGenderHS = new TextBox();
            txtAddressHS = new TextBox();
            btnDeleteHS = new Button();
            btnUpdateHS = new Button();
            cboClassHS = new ComboBox();
            btnBack = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 57);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên học sinh";
            // 
            // btnAddHS
            // 
            btnAddHS.Location = new Point(21, 252);
            btnAddHS.Name = "btnAddHS";
            btnAddHS.Size = new Size(120, 56);
            btnAddHS.TabIndex = 2;
            btnAddHS.Text = "Thêm";
            btnAddHS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 0;
            label2.Text = "Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 140);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 188);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ";
            // 
            // txtNameHS
            // 
            txtNameHS.AcceptsReturn = true;
            txtNameHS.Location = new Point(137, 54);
            txtNameHS.Name = "txtNameHS";
            txtNameHS.Size = new Size(344, 27);
            txtNameHS.TabIndex = 1;
            // 
            // txtGenderHS
            // 
            txtGenderHS.Location = new Point(137, 137);
            txtGenderHS.Name = "txtGenderHS";
            txtGenderHS.Size = new Size(344, 27);
            txtGenderHS.TabIndex = 1;
            // 
            // txtAddressHS
            // 
            txtAddressHS.Location = new Point(137, 185);
            txtAddressHS.Name = "txtAddressHS";
            txtAddressHS.Size = new Size(344, 27);
            txtAddressHS.TabIndex = 1;
            // 
            // btnDeleteHS
            // 
            btnDeleteHS.Location = new Point(361, 252);
            btnDeleteHS.Name = "btnDeleteHS";
            btnDeleteHS.Size = new Size(120, 56);
            btnDeleteHS.TabIndex = 2;
            btnDeleteHS.Text = "Xóa";
            btnDeleteHS.UseVisualStyleBackColor = true;
            // 
            // btnUpdateHS
            // 
            btnUpdateHS.Location = new Point(183, 252);
            btnUpdateHS.Name = "btnUpdateHS";
            btnUpdateHS.Size = new Size(120, 56);
            btnUpdateHS.TabIndex = 2;
            btnUpdateHS.Text = "Cập nhật";
            btnUpdateHS.UseVisualStyleBackColor = true;
            // 
            // cboClassHS
            // 
            cboClassHS.FormattingEnabled = true;
            cboClassHS.Location = new Point(137, 94);
            cboClassHS.Name = "cboClassHS";
            cboClassHS.Size = new Size(344, 28);
            cboClassHS.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(523, 325);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 56);
            btnBack.TabIndex = 2;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(523, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmEditHS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 393);
            Controls.Add(btnSave);
            Controls.Add(cboClassHS);
            Controls.Add(btnUpdateHS);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteHS);
            Controls.Add(btnAddHS);
            Controls.Add(txtAddressHS);
            Controls.Add(txtGenderHS);
            Controls.Add(txtNameHS);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditHS";
            Text = "Cập nhật thông tin học sinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddHS;
        private TextBox txtClass;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNameHS;
        private TextBox txtGenderHS;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button btnUpdateHS;
        private ComboBox cboClassHS;
        private Button btnBack;
        private TextBox txtAddressHS;
        private Button btnDeleteHS;
        private Button btnSave;
    }
}