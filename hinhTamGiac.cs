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
    public partial class hinhTamGiac : Form
    {
        public hinhTamGiac()
        {
            InitializeComponent();
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            double canhA = Double.Parse(txtCanhA.Text);
            double canhB = Double.Parse(txtCanhB.Text);
            double canhC = Double.Parse(txtCanhC.Text);
            double ketqua = canhA + canhB + canhC;
            lblKetQua.Text = Convert.ToString(ketqua);
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhVuong hv = new hinhVuong();
            hv.Show();
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
