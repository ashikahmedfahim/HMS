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
        DBAccess dbobj;
        DataTable dtUser;
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
            MessageBox.Show("Charges for the services");
        }

        private void patient_service_panel_Load(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = ("SELECT NAME FROM SERVICES");
            dbobj.readDatathroughAdapter(query, dtUser);
            foreach(DataRow dr in dtUser.Rows)
            {
                comboBox_service.Items.Add(dr["NAME"].ToString());
            }
            dbobj.closeConn();
        }

        private void btn_service_submit_Click(object sender, EventArgs e)
        {
        }

        private void btn_show_charge_Click(object sender, EventArgs e)
        {
            if (comboBox_service.SelectedIndex>0 || comboBox_service.SelectedIndex ==0)
            {
                //lbl_charge.Text = comboBox_service.SelectedItem.ToString();
                string name = comboBox_service.SelectedItem.ToString();

                dbobj = new DBAccess();
                dtUser = new DataTable();
                string query = "SELECT CHARGE FROM SERVICES WHERE NAME= '" + name + "'";
                dbobj.readDatathroughAdapter(query, dtUser);
                if (dtUser.Rows.Count == 1)
                {
                    lbl_charge.Text = dtUser.Rows[0]["CHARGE"].ToString();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                dbobj.closeConn();
            }
            else
            {

                MessageBox.Show("Please select service");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_service_panel"].BringToFront();
            }
        }
    }
}
