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
    public partial class admin_panel : UserControl
    {
        static admin_panel _obj2;

        public static admin_panel Instance_2
        {
            get
            {
                if (_obj2 == null)
                {
                    _obj2 = new admin_panel();
                }
                return _obj2;
            }
        }
        public Panel PnlContainer_2
        {
            get { return panel_ad_right; }
            set { panel_ad_right = value; }
        }
        public admin_panel()
        {
            InitializeComponent();
        }

        private void lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_doctor"))
            {
                admin_doctor ad_d = new admin_doctor();
                ad_d.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_d);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_doctor"].BringToFront();
            //panel_ad_right.Controls["admin_doctor"].BringToFront();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            _obj2 = this;
            admin_panel_home ad_p_h = new admin_panel_home();
            ad_p_h.Dock = DockStyle.Fill;
            panel_ad_right.Controls.Add(ad_p_h);
            panel_ad_right.Controls["admin_panel_home"].BringToFront();

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_details"))
            {
                admin_details da = new admin_details();
                da.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(da);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_details"].BringToFront();

        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_patient"))
            {
                admin_patient ad_p = new admin_patient();
                ad_p.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_p);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_patient"].BringToFront();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_service"))
            {
                admin_service ad_s = new admin_service();
                ad_s.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_s);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_service"].BringToFront();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_room"))
            {
                admin_room ad_r = new admin_room();
                ad_r.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_r);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_room"].BringToFront();
        }

        private void panel_ad_right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_admin_home_Click(object sender, EventArgs e)
        {
            /*if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_panel_home))
            {
                admin_panel_home ad_p_h_2 = new admin_panel_home();
                ad_p_h_2.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_p_h_2);
            }*/
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_panel_home"].BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lg);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }
    }
}
