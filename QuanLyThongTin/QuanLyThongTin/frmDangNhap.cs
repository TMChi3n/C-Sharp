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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String tenAdmin = txtName.Text;
            String mkAdmin = txtPassword.Text;

            if (checkLogin(tenAdmin, mkAdmin))
            {
                MessageBox.Show("Đăng nhập thành công");
                frmHome frmHome = new frmHome();
                frmHome.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private bool checkLogin(String tenAdmin, String mkAdmin)
        {
            using (SqlConnection conn = Global.getConnection())
            {
                String sql = "select count(*) from admin where tenAdmin=@tenAdmin and mkAdmin=@mkAdmin";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tenAdmin", tenAdmin);
                    cmd.Parameters.AddWithValue("@mkAdmin", mkAdmin);

                    try
                    {
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
