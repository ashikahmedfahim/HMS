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
    public partial class firstpage : UserControl
    {
        public firstpage()
        {
            InitializeComponent();
        }

        private void btn_signup_MouseHover(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.Aqua;
        }

        private void btn_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.White;
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Aqua;

        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lg);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("signup"))
            {
                signup su = new signup();
                su.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(su);
            }
            Form1.Instance.PnlContainer.Controls["signup"].BringToFront();
        }

        private void firstpage_Load(object sender, EventArgs e)
        {

        }
    }
}
