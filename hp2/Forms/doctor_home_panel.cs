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
        public doctor_home_panel()
        {
            InitializeComponent();
            label1.Text = login.genUserId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            login.genUserId = "";
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
    }
}
