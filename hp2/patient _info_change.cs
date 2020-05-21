using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hp2
{
    public partial class patient__info_change : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        public patient__info_change()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_details_panel"))
            {
                patient_details_panel p_d_p = new patient_details_panel();
                p_d_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_d_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_details_panel"].BringToFront();
        }

        private void btn_patient_info_change_Click(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            dbobj.closeConn();
            if (txtbox_new_address.Text == "" && txtxbox_new_phone_no.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
            {
                if (txtbox_new_address.Text != "")
                {
                    string query = "UPDATE USER_INFO  SET ADDRESS='" + txtbox_new_address.Text + "' WHERE USER_ID = '" + login.getId() + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    int res = dbobj.executeQuery(updateCommand);
                    //if (res == 1)
                    //{                   
                    //}
                }
                if (txtxbox_new_phone_no.Text != "")
                {
                    string query = "UPDATE USER_INFO  SET PHONE='" + txtxbox_new_phone_no.Text + "' WHERE USER_ID = '" + login.getId() + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    int res = dbobj.executeQuery(updateCommand);
                    //if (res == 1)
                    //{
                    //    MessageBox.Show("Update Successful");
                    //}
                }
                MessageBox.Show("Update Successful");
                //txtbox_new_address.Text = "";
                txtbox_new_address.Text = "";
                txtxbox_new_phone_no.Text = "";
                //patient_details_panel p_d_p2 = new patient_details_panel();
                //p_d_p2.load();
                if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_details_panel"))
                {
                    patient_details_panel p_d_p = new patient_details_panel();
                    p_d_p.Dock = DockStyle.Fill;
                    patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_d_p);
                }
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_details_panel"].BringToFront();
                
                dbobj.closeConn();

            }
        }
    }
}
