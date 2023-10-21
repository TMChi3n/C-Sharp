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
            List<Khoa> lst = Khoa.ListKhoa();
            // linq
            cboKhoa.DataSource = lst;
            cboKhoa.DisplayMember = "tenKhoa";
            cboKhoa.ValueMember = "idKhoa";
        }

        private void FillCboLop()
        {
            List<Lop> lst = Lop.ListLop();
            cboLop.DataSource = lst;
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "idLop";
        }

        private void FillKhoa()
        {
            int idKhoa = Global.ToInt(cboKhoa.SelectedValue);
            SqlConnection conn = Global.getConnection();
            String sql = @"select G.idGV, G.tenGV, G.gioiTinh, G.queQuan, K.tenKhoa, L.tenLop 
                            from GiaoVien G
                            join Khoa K on G.idKhoa = K.idKhoa
                            join Lop L on G.idLop = L.idLop";
            if (idKhoa > 0)
            {
                sql += " where G.idKhoa=@idKhoa";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("idKhoa", SqlDbType.Int).Value = idKhoa;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgViewGV.DataSource = dt;
        }

        private void FillLop()
        {
            int idLop = Global.ToInt(cboLop.SelectedValue);
            SqlConnection conn = Global.getConnection();
            String sql = @"select G.idGV, G.tenGV, G.gioiTinh, G.queQuan, K.tenKhoa, L.tenLop 
                            from GiaoVien G
                            join Khoa K on G.idKhoa = K.idKhoa
                            join Lop L on G.idLop = L.idLop";
            if (idLop > 0)
            {
                sql += " where G.idLop=@idLop";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("idLop", SqlDbType.Int).Value = idLop;
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
                this.Close();
                frmEditGV edit = new frmEditGV(idGV);
                edit.DataAdded += Edit_DataAdded;
                edit.Show();

            }
        }
        private void Edit_DataAdded(object sender, EventArgs e)
        {
            DataTable updatedData = RetrieveDataFromDatabase(); // Call your data retrieval method
            dgViewGV.DataSource = updatedData; // Set the DataGridView's data source to the updated data
        }

        private DataTable RetrieveDataFromDatabase()
        {
            using (SqlConnection connection = Global.getConnection())
            {

                string query = "SELECT * FROM GiaoVien";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

    }
}
