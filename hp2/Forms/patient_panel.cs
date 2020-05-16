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
    public partial class patient_panel : UserControl
    {
        static patient_panel _obj4;

        public static patient_panel Instance_4
        {
            get
            {
                if (_obj4 == null)
                {
                    _obj4 = new patient_panel();
                }
                return _obj4;
            }
        }
        public Panel PnlContainer_4
        {
            get { return patient_panel_right_side; }
            set { patient_panel_right_side = value; }
        }
        public patient_panel()
        {
            InitializeComponent();
        }

        private void patient_panel_Load(object sender, EventArgs e)
        {
            _obj4 = this;
            patient_panel_home p_p_h = new patient_panel_home();
            p_p_h.Dock = DockStyle.Fill;
            patient_panel_right_side.Controls.Add(p_p_h);
            patient_panel_right_side.Controls["patient_panel_home"].BringToFront();
        }

        private void btn_patient_appointment_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_appointment_panel"))
            {
                patient_appointment_panel p_a_p = new patient_appointment_panel();
                p_a_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
        }

        private void btn_patient_services_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_service_panel"))
            {
                patient_service_panel p_s_p = new patient_service_panel();
                p_s_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_s_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_service_panel"].BringToFront();
        }

        private void btn_patient_reports_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_report_panel"))
            {
                patient_report_panel p_r_p = new patient_report_panel();
                p_r_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_r_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_report_panel"].BringToFront();
        }

        private void btn_patient_details_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_details_panel"))
            {
                patient_details_panel p_d_p = new patient_details_panel();
                p_d_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_d_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_details_panel"].BringToFront();
        }
    }
}
