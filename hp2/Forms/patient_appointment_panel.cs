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
    public partial class patient_appointment_panel : UserControl
    {
        static patient_appointment_panel _obj;

        public static patient_appointment_panel Instance_4
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new patient_appointment_panel();
                }
                return _obj;
            }
        }
        public Panel PnlContainer_4
        {
            get { return main_panel; }
            set { main_panel = value; }
        }
        public patient_appointment_panel()
        {
            InitializeComponent();
        }

        private void btn_change_time_Click(object sender, EventArgs e)
        {
            if (!patient_appointment_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_appointment_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }

        private void btn_change_time_Click_1(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }
    
    }
    
}
