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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHS hs = new frmHS();
            hs.Show();
            this.Hide();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGV gv = new frmGV();
            gv.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }
    }
}
