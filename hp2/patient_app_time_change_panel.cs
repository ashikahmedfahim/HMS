﻿using System;
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
    public partial class patient_app_time_change_panel : UserControl
    {
        public patient_app_time_change_panel()
        {
            InitializeComponent();
        }

        private void patient_app_time_change_panel_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_appointment_panel"))
            {
                patient_appointment_panel p_a_p = new patient_appointment_panel();
                p_a_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
        }
    }
}
