using Plasmoid.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuehneNaggelMAIN
{

    public partial class Main_Menu : Form
    {
        private Button currentButton;
        private Form activeForm;
        private void DisableButton()


        {
            foreach (Control previousBtn in panel3.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(238, 243, 246);
                    previousBtn.ForeColor = Color.FromArgb(35, 44, 75);
                    previousBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = System.Drawing.Color.FromArgb(103, 179, 228);
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
                    }
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            NameWindow.Text = childForm.Text;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RouteFinder(), sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Network(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Statistics(), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Database(), sender);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 1, 1, panel4.Width - 1, panel4.Height - 1, 10);
        }
    }
}
