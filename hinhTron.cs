using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccpp
{
    public partial class hinhTron : Form
    {
        public hinhTron()
        {
            InitializeComponent();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            double bankinh = Double.Parse(txtBanKinh.Text);
            double ketqua = 2 * Math.PI * bankinh;
            lblKetQua.Text = Convert.ToString(ketqua);
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhVuong hv = new hinhVuong();
            hv.Show();
            Hide();
        }

        private void hìnhTamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhTamGiac htg = new hinhTamGiac();
            htg.Show();
            Hide();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hìnhChữNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhChuNhat hcn = new hinhChuNhat();
            hcn.Show();
            Hide();
        }
    }
}
