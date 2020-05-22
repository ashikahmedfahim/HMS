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
    public partial class patient_app_cancel_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser, dtUser1, dtUser2;
        string time, dname, get_d_id, get_customer_id, get_time;
        //string c, d, e, f, g, h, i, j;
        public void load()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = ("SELECT NAME FROM USER_INFO WHERE USER_ID LIKE 'd%' order by USER_ID");
            dbobj.readDatathroughAdapter(query, dtUser);
            cbox_patient_doc_name.Items.Clear();
            foreach (DataRow dr in dtUser.Rows)
            {
                cbox_patient_doc_name.Items.Add(dr["NAME"].ToString());
            }
        }
        private void patient_app_cancel_panel_Load(object sender, EventArgs e)
        {
            load();
        }

        public patient_app_cancel_panel()
        {
            InitializeComponent();
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
        public void Doctor_ID()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query3 = "SELECT ID FROM USER_INFO WHERE NAME = '" + dname + "'";
            SqlDataReader select_info2 = dbobj.readDatathroughReader(query3);
            while (select_info2.Read())
            {
                get_d_id = select_info2["ID"].ToString();
            }
            dbobj.closeConn();

        }
        public void Customer_ID()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query4 = "SELECT ID FROM USER_INFO WHERE USER_ID = '" + login.getId() + "'";
            SqlDataReader select_info3 = dbobj.readDatathroughReader(query4);
            while (select_info3.Read())
            {
                get_customer_id = select_info3["ID"].ToString();
            }
            dbobj.closeConn();
        }
        public void maintimeset()
        {
            dbobj = new DBAccess();
            dtUser1 = new DataTable();
            Doctor_ID();
            Customer_ID();
            cbox_patient_doc_time.Items.Clear();
            string query4 = "SELECT TIME FROM CUS_DOC WHERE CID='" + get_customer_id + "' AND DID='" + get_d_id + "' AND DATE='" + dateTimePicker1.Value + "' ORDER BY TIME ASC";
            dbobj.readDatathroughAdapter(query4, dtUser1);
            foreach (DataRow dr in dtUser1.Rows)
            {
                cbox_patient_doc_time.Items.Add(dr["TIME"].ToString());
            }
            dbobj.closeConn();
        }

        private void btn_patient_ap_delete_Click(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser2 = new DataTable();
            string a = cbox_patient_doc_time.SelectedItem.ToString();
            string query = "DELETE FROM CUS_DOC WHERE CID='" + get_customer_id + "' AND DID='" + get_d_id + "' AND DATE='" + dateTimePicker1.Value + "' AND TIME='" + a + "'";
            SqlCommand deleteCommand = new SqlCommand(query);
            dbobj.executeQuery(deleteCommand);
            MessageBox.Show("Deleted.");
            cbox_patient_doc_name.Items.Clear();
            cbox_patient_doc_time.Items.Clear();
            cbox_patient_doc_name.Text = "";
            cbox_patient_doc_time.Text = "";
            load();

        }

        private void btn_doctor_select_Click(object sender, EventArgs e)
        {
            if (cbox_patient_doc_name.SelectedIndex > 0 || cbox_patient_doc_name.SelectedIndex == 0)
            {
                cbox_patient_doc_time.Items.Clear();
                dname = cbox_patient_doc_name.SelectedItem.ToString();
                cbox_patient_doc_time.Items.Clear();
                maintimeset();
            }
            else
            {
                MessageBox.Show("Please select doctor");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_cancel_panel"].BringToFront();
            }
        }
    }
}
