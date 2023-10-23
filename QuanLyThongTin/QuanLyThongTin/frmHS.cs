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
    public partial class frmHS : Form
    {
        public frmHS()
        {
            InitializeComponent();
            fillCboLop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();
            this.Close();
        }

        private void fillCboLop()
        {
            List<Lop> lst = Lop.ListLop();
            cboLop.DataSource = lst;
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "idLop";
        }
        private void FillLop()
        {
            int idLop = Global.ToInt(cboLop.SelectedValue);
            SqlConnection conn = Global.getConnection();
            String sql = @"select H.idHS, H.tenHS, H.gioiTinh, H.queQuan, L.tenLop
	                            from HocSinh H
	                            join Lop L on H.idLop=L.idLop";
            if (idLop > 0)
            {
                sql += " where H.idLop=@idLop";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("idLop", SqlDbType.Int).Value = idLop;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgViewHS.DataSource = dt;
        }


        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillLop();
        }

        private void dgViewHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dg = dgViewHS.Rows[e.RowIndex];
            if (dg != null)
            {
                int idHS = Global.ToInt(dg.Cells["idHS"].Value);
                this.Close();
                frmEditHS edit = new frmEditHS(idHS);
                edit.DataAdded += Edit_DataAdded;
                edit.Show();
            }
        }

        private void Edit_DataAdded(object sender, EventArgs e)
        {
            DataTable updatedData = RetrieveDataFromDatabase(); // Call your data retrieval method
            dgViewHS.DataSource = updatedData; // Set the DataGridView's data source to the updated data
        }

        private DataTable RetrieveDataFromDatabase()
        {
            using (SqlConnection connection = Global.getConnection())
            {

                string query = "SELECT * FROM HocSinh";

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
