using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp2.Forms
{
    public partial class patient_logout_panel : UserControl
    {
        public patient_logout_panel()
        {
            InitializeComponent();
        }

        private void patient_logout_panel_MouseHover(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.Aqua;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.White;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
          
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lgn = new login();
                lgn.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lgn);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }
    }
}
