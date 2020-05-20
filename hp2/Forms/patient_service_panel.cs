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
    public partial class patient_service_panel : UserControl
    {
        public patient_service_panel()
        {
            InitializeComponent();
        }

        private void btn_info_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select the Services you wants to do from this Hospital");
        }

        private void btn_info_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select the Payment Mathod you wants to pay for the services");
        }
    }
}
