using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;

namespace GreenLifeOrganicStore.Utils
{

    public static class UIHelper
    {
        // --- LUXURY ORGANIC DESIGN SYSTEM ---
        public static Color PrimaryColor = Color.FromArgb(27, 48, 34);      // Deep Forest Green
        public static Color SecondaryColor = Color.FromArgb(45, 106, 79);   // Lush Emerald
        public static Color AccentColor = Color.FromArgb(212, 175, 55);     // Metallic Gold
        public static Color BackgroundColor = Color.FromArgb(249, 247, 242); // Soft Cream/Paper
        public static Color TextPrimary = Color.FromArgb(10, 25, 47);       // Deep Navy/Black
        public static Color TextSecondary = Color.FromArgb(85, 87, 85);     // Slate Gray
        public static Color SurfaceColor = Color.White;                    // Card Background
        public static Color BorderColor = Color.FromArgb(220, 222, 220);    // Thin Borders
        public static string CurrencySymbol = "LKR";

        public static string FormatCurrency(decimal amount)
        {
            return $"{CurrencySymbol} {amount:N2}";
        }

        public static void StyleForm(Form form)
        {
            form.BackColor = BackgroundColor;
            form.Font = new Font("Segoe UI", 10F);
        }

        public static void StyleButton(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = isPrimary ? PrimaryColor : Color.Transparent;
            btn.ForeColor = isPrimary ? Color.White : PrimaryColor;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;
            if (!isPrimary)
            {
                btn.FlatAppearance.BorderColor = PrimaryColor;
                btn.FlatAppearance.BorderSize = 1;
            }
            btn.MouseEnter += (s, e) => {
                btn.BackColor = isPrimary ? SecondaryColor : Color.FromArgb(240, 240, 240);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = isPrimary ? PrimaryColor : Color.Transparent;
            };
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 11F);
            txt.BackColor = Color.White;
            txt.ForeColor = TextPrimary;
        }

        public static void StyleNumeric(NumericUpDown nud)
        {
            nud.BorderStyle = BorderStyle.FixedSingle;
            nud.Font = new Font("Segoe UI", 11F);
            nud.BackColor = Color.White;
            nud.ForeColor = TextPrimary;
        }

        public static void StyleComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.Font = new Font("Segoe UI", 11F);
            cmb.BackColor = Color.White;
            cmb.ForeColor = TextPrimary;
        }

        public static void StyleLabel(Label lbl, bool isHeader = false)
        {
            if (isHeader)
            {
                lbl.Font = new Font("Segoe UI Semibold", 18F);
                lbl.ForeColor = Color.White;
            }
            else
            {
                lbl.Font = new Font("Segoe UI", 10F);
                lbl.ForeColor = TextSecondary;
                lbl.AutoSize = true;
            }
        }

        public static void StyleDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = SurfaceColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.GridColor = Color.FromArgb(235, 237, 235);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dgv.ColumnHeadersHeight = 45;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.SelectionBackColor = SecondaryColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowTemplate.Height = 40;
            dgv.AutoGenerateColumns = true;
            dgv.Visible = true;
        }

        public static void StyleGroupBox(GroupBox gb)
        {
            gb.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            gb.ForeColor = PrimaryColor;
            gb.BackColor = Color.Transparent;
        }

        public static void CreateMetricCard(Panel pnl, Label title, Label value, Color accent)
        {
            pnl.BackColor = SurfaceColor;
            pnl.Size = new Size(280, 110);
            
            title.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            title.ForeColor = TextSecondary;
            title.AutoSize = true;
            title.Location = new Point(20, 20);
            
            value.Font = new Font("Segoe UI Semibold", 20F);
            value.ForeColor = accent;
            value.AutoSize = true;
            value.Location = new Point(20, 45);
            pnl.Paint += (s, e) => {
                using (Pen p = new Pen(accent, 5))
                {
                    e.Graphics.DrawLine(p, 0, 0, 0, pnl.Height);
                }
            };
        }

        public static void StyleDashboardButton(Button btn, string text)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(180, 200, 180);
            btn.Font = new Font("Segoe UI Semibold", 10.5F);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Text = " " + text;
            btn.Cursor = Cursors.Hand;
            btn.Height = 50;
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(40, 60, 45);
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(180, 200, 180);
            };
        }

        public static void StyleLogoutButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 80, 80);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(255, 100, 100);
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;
            btn.Text = "  Logout  ";
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(200, 80, 80);
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(255, 100, 100);
            };
        }

        public static void DrawShadow(Graphics g, Rectangle bounds)
        {
            for (int i = 0; i <= 3; i++)
            {
                using (Pen p = new Pen(Color.FromArgb(10 - (i * 2), 0, 0, 0)))
                {
                    g.DrawRectangle(p, new Rectangle(bounds.X - i, bounds.Y - i, bounds.Width + (i * 2), bounds.Height + (i * 2)));
                }
            }
        }

        public static void DrawGradientBackground(Control ctrl, Graphics g)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                ctrl.ClientRectangle,
                Color.FromArgb(27, 48, 34),
                Color.FromArgb(15, 30, 20),
                90F))
            {
                g.FillRectangle(brush, ctrl.ClientRectangle);
            }
        }
    }
}
