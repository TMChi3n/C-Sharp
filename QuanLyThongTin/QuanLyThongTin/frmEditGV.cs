﻿using QuanLyThongTin.Model;
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
    public partial class frmEditGV : Form
    {
        int idGV = 0;
        public delegate void Data_Changed(object obj);
        public Data_Changed datachanged_event;

        public Data_Changed textchangetest_event;

        bool flagADD = false;
        public frmEditGV()
        {
            InitializeComponent();
        }

        public frmEditGV(int idGV)
        {
            InitializeComponent();
            this.idGV = idGV;
            fillCboKhoa();
            fillCboLop();
        }

        public void fillCboKhoa()
        {
            SqlConnection conn = Global.getConnection();
            String sql = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cboKhoaGV.DataSource = dt;
            cboKhoaGV.DisplayMember = "tenKhoa";
            cboKhoaGV.ValueMember = "idKhoa";

            DataRow dr = dt.NewRow();
            dr["tenKhoa"] = "========CHƯA CHỌN===========";
            dr["idKhoa"] = 0;
            dt.Rows.InsertAt(dr, 0);
        }
        public void fillCboLop()
        {
            SqlConnection conn = Global.getConnection();
            String sql = "select * from Lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cboLopGV.DataSource = dt;
            cboLopGV.DisplayMember = "tenLop";
            cboLopGV.ValueMember = "idLop";

            DataRow dr = dt.NewRow();
            dr["tenLop"] = "========CHƯA CHỌN===========";
            dr["idLop"] = 0;
            dt.Rows.InsertAt(dr, 0);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGV gv = new frmGV();
            gv.Show();
            this.Close();
        }

        private void loadData()
        {
            GiaoVien gv = GiaoVien.getGVById(this.idGV);
            txtNameGV.Text = gv.tenGV;
            cboKhoaGV.SelectedValue = gv.idKhoa;
            cboLopGV.SelectedValue = gv.idLop;
            txtGenderGV.Text = gv.gioiTinh;
            txtAddressGV.Text = gv.queQuan;
        }

        private void allowEdit(bool ok)
        {
            txtNameGV.Enabled = ok;
            cboKhoaGV.Enabled = ok;
            cboLopGV.Enabled = ok;
            txtGenderGV.Enabled = ok;
            txtAddressGV.Enabled = ok;
        }

        private void setBlank()
        {
            txtNameGV.Text = "";
            txtGenderGV.Text = "";
            txtAddressGV.Text = "";
            cboKhoaGV.SelectedValue = 0;
            cboLopGV.SelectedValue= 0;
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            this.flagADD = true;
            setBlank();
            allowEdit(true);
        }

        private void btnUpdateGV_Click(object sender, EventArgs e)
        {
            this.flagADD = false;
            allowEdit(true);
        }

        private void btnDeleteGV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool ok = GiaoVien.deleteGV(this.idGV);
                if (ok)
                {
                    setBlank();
                    MessageBox.Show("Đã xóa thành công vào cơ sở dữ liệu", "Thông báo");
                    if (datachanged_event != null)
                        datachanged_event("Tôi đã xóa dữ liệu");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật", "Thông báo");
                }

            }
        }

        private void frmEditGV_Load(object sender, EventArgs e)
        {
            loadData();
            allowEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.flagADD)
            {
                updateGiaoVien();
            } else
            {
                insertGiaoVien();
            }
        }

        private void insertGiaoVien()
        {
            GiaoVien gv = new GiaoVien();
            gv.idGV = this.idGV;
            gv.tenGV = txtNameGV.Text;
            gv.queQuan = txtAddressGV.Text;
            gv.gioiTinh = txtGenderGV.Text;
            gv.idKhoa = Global.ToInt(cboKhoaGV.SelectedValue);
            gv.idLop = Global.ToInt(cboLopGV.SelectedValue);

            bool ok = GiaoVien.insertGV(gv);
            if(ok)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                if(datachanged_event != null)
                {
                    datachanged_event("Dữ liệu vừa cập nhật");
                }
            } else
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
        private void updateGiaoVien()
        {
            GiaoVien gv = new GiaoVien();
            gv.idGV = this.idGV;
            gv.tenGV = txtNameGV.Text;
            gv.queQuan = txtAddressGV.Text;
            gv.gioiTinh = txtGenderGV.Text;
            gv.idKhoa = Global.ToInt(cboKhoaGV.SelectedValue);
            gv.idLop = Global.ToInt(cboLopGV.SelectedValue);

            bool ok = GiaoVien.insertGV(gv);
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
