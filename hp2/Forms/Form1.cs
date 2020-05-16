using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp2
{
    public partial class Form1 : Form
    {

        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void login1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;

            //login lg = new login();
            //lg.Dock = DockStyle.Fill;
            //panelContainer.Controls.Add(lg);
            //PnlContainer.Controls["login"].BringToFront();
            firstpage fp = new firstpage();
            fp.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(fp);
            PnlContainer.Controls["firstpage"].BringToFront();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(146, 232, 252);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(2, 11, 23);
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.FromArgb(146, 232, 252);
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.FromArgb(2, 11, 23);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
