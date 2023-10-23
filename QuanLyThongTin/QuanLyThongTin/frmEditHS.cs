using QuanLyThongTin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTin
{
    public partial class frmEditHS : Form
    {
        int idHS = 0;
        public delegate void Data_Changed(object obj);
        public Data_Changed datachanged_event;

        public delegate void DataAddedEventHandler(object sender, EventArgs e);
        public event DataAddedEventHandler DataAdded;

        bool flagADD = false;
        public frmEditHS()
        {
            InitializeComponent();
        }

        public frmEditHS(int idHS)
        {
            InitializeComponent();
            this.idHS = idHS;
            fillCboLop();
        }

        public void fillCboLop()
        {
            SqlConnection conn = Global.getConnection();
            String sql = "select * from Lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cboClassHS.DataSource = dt;
            cboClassHS.DisplayMember = "tenLop";
            cboClassHS.ValueMember = "idLop";

            DataRow dr = dt.NewRow();
            dr["tenLop"] = "Chọn lớp";
            dr["idLop"] = 0;
            dt.Rows.InsertAt(dr, 0);
        }

        private void loadData()
        {
            HocSinh hs = HocSinh.getHSById(this.idHS);
            txtNameHS.Text = hs.tenHS;
            cboClassHS.SelectedValue = hs.idLop;
            txtGenderHS.Text = hs.gioiTinh;
            txtAddressHS.Text = hs.queQuan;
        }

        private void allowEdit(bool ok)
        {
            txtNameHS.Enabled = ok;
            cboClassHS.Enabled = ok;
            txtGenderHS.Enabled = ok;
            txtAddressHS.Enabled = ok;
        }

        private void setBlank()
        {
            txtNameHS.Text = "";
            txtGenderHS.Text = "";
            txtAddressHS.Text = "";
            cboClassHS.SelectedValue = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHS hs = new frmHS();
            hs.Show();
            this.Close();
        }

        private void btnAddHS_Click(object sender, EventArgs e)
        {
            this.flagADD = true;
            setBlank();
            allowEdit(true);
        }

        private void btnUpdateHS_Click(object sender, EventArgs e)
        {
            this.flagADD = false;
            allowEdit(true);
        }

        private void btnDeleteHS_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool ok = HocSinh.deleteHS(this.idHS);
                if (ok)
                {
                    setBlank();
                    MessageBox.Show("Đã xóa dữ liệu thành công", "Thông báo");
                    if (datachanged_event != null)
                        datachanged_event("Tôi đã xóa dữ liệu");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật", "Thông báo");
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.flagADD)
            {
                updateHS();
            }
            else
            {
                insertHS();
            }
        }

        private void frmEditHS_Load(object sender, EventArgs e)
        {
            loadData();
            allowEdit(false);
        }

        private void updateHS()
        {
            HocSinh hs = new HocSinh();
            hs.idHS = this.idHS;
            hs.tenHS = txtNameHS.Text;
            hs.queQuan = txtAddressHS.Text;
            hs.gioiTinh = txtGenderHS.Text;
            hs.idLop = Global.ToInt(cboClassHS.SelectedValue);

            bool ok = HocSinh.updateHS(hs);
            if (ok)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                if (datachanged_event != null)
                {
                    datachanged_event("Đã cập nhật thành công dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void insertHS()
        {
            HocSinh hs = new HocSinh();
            hs.idHS = this.idHS;
            hs.tenHS = txtNameHS.Text;
            hs.queQuan = txtAddressHS.Text;
            hs.gioiTinh = txtGenderHS.Text;
            hs.idLop = Global.ToInt(cboClassHS.SelectedValue);

            bool ok = HocSinh.insertHS(hs);
            if (ok)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                if (datachanged_event != null)
                {
                    datachanged_event("Dữ liệu vừa cập nhật");
                }
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
