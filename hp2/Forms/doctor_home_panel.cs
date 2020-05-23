using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp2
{
    public partial class doctor_home_panel : UserControl
    {
        private string user_id;
        public doctor_home_panel()
        {
            InitializeComponent();
        }

        public doctor_home_panel(string x)
        {
            InitializeComponent();
            user_id = x;
            label1.Text = user_id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lgn = new login();
                lgn.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lgn);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }

        private void doctor_home_panel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
