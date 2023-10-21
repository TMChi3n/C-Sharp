using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();
            this.Close();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgViewHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
