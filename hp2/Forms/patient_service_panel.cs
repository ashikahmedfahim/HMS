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
    public partial class patient_service_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        string id;
        public patient_service_panel()
        {
            InitializeComponent();
        }

        private void btn_info_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select the Services you wants to DELETE");
        }

        private void btn_info_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Charges for the services");
        }
        public void load()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = ("SELECT C.NAME FROM USER_INFO A ,CUS_SER B,SERVICES C WHERE A.USER_ID= '" + login.getId() + "' AND A.ID=B.CID AND B.SID=C.ID");
            dbobj.readDatathroughAdapter(query, dtUser);
            foreach (DataRow dr in dtUser.Rows)
            {
                comboBox_service.Items.Add(dr["NAME"].ToString());
            }
            dbobj.closeConn();
        }
        private void patient_service_panel_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_service_submit_Click(object sender, EventArgs e)
        {
            if (comboBox_service.SelectedIndex > 0 || comboBox_service.SelectedIndex == 0)
            {
                string name = comboBox_service.SelectedItem.ToString();
                dbobj = new DBAccess();
                dtUser = new DataTable();
                string query2 = "SELECT B.SID FROM SERVICES A,CUS_SER B WHERE A.NAME = '" + name + "' AND A.ID=B.SID";
                SqlDataReader select_info = dbobj.readDatathroughReader(query2);
                while (select_info.Read())
                {
                    id = select_info["SID"].ToString();
                }
                dbobj.closeConn();

                dbobj = new DBAccess();
                dtUser = new DataTable();
                string query = "DELETE FROM CUS_SER WHERE SID = '" + id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                dbobj.executeQuery(deleteCommand);
                MessageBox.Show("Deleted.");
                dbobj.closeConn();
                comboBox_service.Items.Clear();
                comboBox_service.Text = "";
                lbl_charge.Text = "invalid";
                load();
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_service_panel"].BringToFront();

            }
            else
            {

                MessageBox.Show("Please select service");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_service_panel"].BringToFront();
            }
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
                    lbl_charge.Text = dtUser.Rows[0]["CHARGE"].ToString()+" BDT";
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
