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
    public partial class hinhVuong : Form
    {
        public hinhVuong()
        {
            InitializeComponent();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            double canh = Double.Parse(txtCanh.Text);
            double ketqua = canh * 4;
            lblKetQua.Text = Convert.ToString(ketqua);
        }

        private void hìnhTamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhTamGiac htg = new hinhTamGiac();
            htg.Show();
            Hide();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhTron ht = new hinhTron();
            ht.Show();
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
