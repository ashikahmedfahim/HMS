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
    public partial class patient_password_change : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        private string user_id;

        public patient_password_change()
        {
            InitializeComponent();
        }

        public patient_password_change(string x)
        {
            InitializeComponent();
            user_id = x;
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

        private void patient_password_change_Load(object sender, EventArgs e)
        {
        }

        private void btn_patient_pass_change_Click(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            dbobj.closeConn();

            string query = "UPDATE USER_INFO  SET PASSWORD='" + txtbox_pass_change.Text + "' WHERE USER_ID = '" + user_id + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            int res = dbobj.executeQuery(updateCommand);
            if (res == 1)
            {
                MessageBox.Show("Update Successful");
                txtbox_pass_change.Text = "";
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
