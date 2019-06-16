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
    public partial class hinhChuNhat : Form
    {
        public hinhChuNhat()
        {
            InitializeComponent();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            double chieudai = Double.Parse(txtChieuDai.Text);
            double chieurong = Double.Parse(txt_ChieuRong.Text);
            double ketqua = (chieudai + chieurong)*2;
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
    }
}
