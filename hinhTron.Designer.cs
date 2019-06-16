namespace ccpp
{
    partial class hinhTron
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hìnhChữNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhVuôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTamGiácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hìnhChữNhậtToolStripMenuItem,
            this.hìnhVuôngToolStripMenuItem,
            this.hìnhTamGiácToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hìnhChữNhậtToolStripMenuItem
            // 
            this.hìnhChữNhậtToolStripMenuItem.Name = "hìnhChữNhậtToolStripMenuItem";
            this.hìnhChữNhậtToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hìnhChữNhậtToolStripMenuItem.Text = "Hình Chữ Nhật";
            this.hìnhChữNhậtToolStripMenuItem.Click += new System.EventHandler(this.hìnhChữNhậtToolStripMenuItem_Click);
            // 
            // hìnhVuôngToolStripMenuItem
            // 
            this.hìnhVuôngToolStripMenuItem.Name = "hìnhVuôngToolStripMenuItem";
            this.hìnhVuôngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.hìnhVuôngToolStripMenuItem.Text = "Hình Vuông";
            this.hìnhVuôngToolStripMenuItem.Click += new System.EventHandler(this.hìnhVuôngToolStripMenuItem_Click);
            // 
            // hìnhTamGiácToolStripMenuItem
            // 
            this.hìnhTamGiácToolStripMenuItem.Name = "hìnhTamGiácToolStripMenuItem";
            this.hìnhTamGiácToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.hìnhTamGiácToolStripMenuItem.Text = "Hình Tam Giác";
            this.hìnhTamGiácToolStripMenuItem.Click += new System.EventHandler(this.hìnhTamGiácToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bán kính";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(258, 175);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(9, 13);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "l";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(272, 73);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(100, 20);
            this.txtBanKinh.TabIndex = 9;
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.Location = new System.Drawing.Point(272, 125);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(100, 23);
            this.btn_KetQua.TabIndex = 10;
            this.btn_KetQua.Text = "Kết quả";
            this.btn_KetQua.UseVisualStyleBackColor = true;
            this.btn_KetQua.Click += new System.EventHandler(this.btn_KetQua_Click);
            // 
            // hinhTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btn_KetQua);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "hinhTron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hinhTron";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hìnhChữNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhVuôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTamGiácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Button btn_KetQua;
    }
}