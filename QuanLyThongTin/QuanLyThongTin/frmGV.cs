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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
            FillCboKhoa();
            FillCboLop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();
            this.Close();
        }

        private void FillCboKhoa()
        {
            DataTable dt = Khoa.ListKhoa();

            DataRow dr = dt.NewRow();
            dr["idKhoa"] = 0;
            dr["tenKhoa"] = " ";
            dt.Rows.InsertAt(dr, 0);

            cboKhoa.DataSource = dt;

            cboKhoa.DisplayMember = "tenKhoa";
            cboKhoa.ValueMember = "idKhoa";
        }

        private void FillCboLop()
        {
            DataTable dt = Lop.ListLop();

            DataRow dr = dt.NewRow();
            dr["idLop"] = 0;
            dr["tenLop"] = " ";
            dt.Rows.InsertAt(dr, 0);

            cboLop.DataSource = dt;

            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "idLop";
        }

        private void FillKhoa()
        {
            int idGV = Global.ToInt(cboKhoa.SelectedValue);
            SqlConnection conn = Global.getConnection();
            String sql = @"select G.idGV, G.tenGV, G.gioiTinh, G.queQuan, K.tenKhoa, L.tenLop 
                            from GiaoVien G
                            join Khoa K on G.idKhoa = k.idKhoa
                            join Lop L on G.idLop = L.idLop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("idGV", SqlDbType.Int).Value = idGV;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgViewGV.DataSource = dt;
        }

        private void FillLop()
        {
            int idGV = Global.ToInt(cboKhoa.SelectedValue);
            SqlConnection conn = Global.getConnection();
            String sql = @"select G.idGV, G.tenGV, G.gioiTinh, G.queQuan, K.tenKhoa, L.tenLop 
                            from GiaoVien G
                            join Khoa K on G.idKhoa = k.idKhoa
                            join Lop L on G.idLop = L.idLop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("idGV", SqlDbType.Int).Value = idGV;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgViewGV.DataSource = dt;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillLop();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillKhoa();
        }

        private void dgViewGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dg = dgViewGV.Rows[e.RowIndex];
            if (dg != null)
            {
                int idGV = Global.ToInt(dg.Cells["idGV"].Value);
                frmEditGV edit = new frmEditGV(idGV);
                edit.datachanged_event += dataChange;
                edit.Show();
            }

        }

        private void dataChange(object obj)
        {
            
        }
    }
}
