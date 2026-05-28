using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQC
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Forms.FrmKhachHang());
        }

        private void đơnVịPhátHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Forms.FrmDonViPhatHanh());
        }

        private void thốngKêBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Forms.FrmThongKeBaiViet());
        }

        private void biểuĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Forms.FrmBieuDo());
        }

        // Helper method to display a form inside the main panel
        private void ShowFormInPanel(Form childForm)
        {
            // Ensure the form is not a top-level window
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Clear previous controls
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
