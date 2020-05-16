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
    public partial class admin_doctor : UserControl
    {
        static admin_doctor _obj;
        public admin_doctor()
        {
            InitializeComponent();
        }
        public static admin_doctor Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new admin_doctor();
                }
                return _obj;
            }
        }
        public Panel panel_ad_right
        {
            get { return panel_ad_right; }
            set { panel_ad_right = value; }
        }

        private void admin_doctors_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_doctor_info_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_edit_doctor_info"))
            {
                admin_edit_doctor_info ad_e_d = new admin_edit_doctor_info();
                ad_e_d.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_e_d);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_edit_doctor_info"].BringToFront();
        }

        private void btn_add_new_doctor_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_add_new_doctor"))
            {
                admin_add_new_doctor ad_a_n_d = new admin_add_new_doctor();
                ad_a_n_d.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_a_n_d);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_add_new_doctor"].BringToFront();
        }
    }
}
