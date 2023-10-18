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

        private void btnAddHS_Click(object sender, EventArgs e)
        {
            frmEditHS editHS = new frmEditHS();
            editHS.Show();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();
            this.Close();
        }
    }
}
