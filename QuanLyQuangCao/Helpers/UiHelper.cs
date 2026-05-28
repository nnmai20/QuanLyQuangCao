using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuangCao.Helpers
{
    public static class UiHelper
    {
        public static readonly Color MAU_CHINH = Color.FromArgb(26, 58, 92);
        public static readonly Color MAU_NEN = Color.FromArgb(240, 242, 245);

        public static void ApplyDgvStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = MAU_CHINH;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 38;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgv.RowTemplate.Height = 32;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 82, 128);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.Dock = DockStyle.Fill;
        }

        public static void ApplyButtonPrimary(Button btn)
        {
            btn.BackColor = MAU_CHINH;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 82, 128);
            btn.Cursor = Cursors.Hand;
            btn.Height = 34;
            btn.Font = new Font("Segoe UI", 9f);
        }

        public static void ApplyButtonSecondary(Button btn)
        {
            btn.BackColor = Color.FromArgb(189, 195, 199);
            btn.ForeColor = Color.FromArgb(44, 62, 80);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Height = 34;
            btn.Font = new Font("Segoe UI", 9f);
        }

        public static void ApplyButtonDanger(Button btn)
        {
            btn.BackColor = Color.FromArgb(192, 57, 43);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 50, 38);
            btn.Cursor = Cursors.Hand;
            btn.Height = 34;
            btn.Font = new Font("Segoe UI", 9f);
        }

        public static void ApplySearchBox(TextBox txt, string placeholder = "Tìm kiếm...")
        {
            txt.AutoSize = false;
            txt.Height = 34;
            txt.Width = 250;
            txt.Font = new Font("Segoe UI", 9.5f);
            txt.BorderStyle = BorderStyle.FixedSingle;
            // Placeholder thủ công
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;
            txt.GotFocus += (s, e) => { if (txt.Text == placeholder) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.LostFocus += (s, e) => { if (txt.Text == "") { txt.Text = placeholder; txt.ForeColor = Color.Gray; } };
        }
    }
}
