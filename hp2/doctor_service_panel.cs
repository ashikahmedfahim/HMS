using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hp2
{
    public partial class doctor_service_panel : UserControl
    {

        DBAccess dbobj;
        DataTable dtUser;
        public doctor_service_panel()
        {
            InitializeComponent();
        }

        private string getDoctorId() {
            DBAccess dbobjy = new DBAccess();
            DataTable  dtUsery = new DataTable();
            string query = ("SELECT ID FROM USER_INFO WHERE USER_ID='"+login.getId()+"'");
            dbobjy.readDatathroughAdapter(query, dtUsery);
            if (dtUsery.Rows.Count == 1) {
                return dtUsery.Rows[0]["ID"].ToString();
            }
            else {
                return "";
            }
        }

        private string getPatientName(string x) {
            DBAccess dbobjx = new DBAccess();
            DataTable dtUserx = new DataTable();
            string query = "SELECT NAME FROM USER_INFO WHERE ID='" +x+ "'";
            dbobjx.readDatathroughAdapter(query, dtUserx);
            if (dtUserx.Rows.Count == 1)
            {
                return dtUserx.Rows[0]["NAME"].ToString();
            }
            else
            {
                return "Not Found";
            }
        }

        private void load() {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = "SELECT CID FROM CUS_DOC WHERE DID = '"+getDoctorId()+"'";
            dbobj.readDatathroughAdapter(query, dtUser);
            comboBoxName.Items.Clear();
            foreach (DataRow dr in dtUser.Rows)
            {
                string x = dr["CID"].ToString();
                string y = getPatientName(x);
                comboBoxName.Items.Add(y);
            }


            DBAccess dbobj1 = new DBAccess();
            DataTable dtUser1 = new DataTable();
            string query1 = "SELECT NAME FROM SERVICES";
            dbobj1.readDatathroughAdapter(query1, dtUser1);
            comboBoxService.Items.Clear();
            foreach (DataRow dr in dtUser1.Rows)
            {
                comboBoxService.Items.Add(dr["NAME"].ToString());
            }


            DBAccess dbobj2 = new DBAccess();
            DataTable dtUser2 = new DataTable();
            string query2 = "SELECT ROOM_NO FROM ROOM";
            dbobj2.readDatathroughAdapter(query2, dtUser2);
            comboBoxRoom.Items.Clear();
            foreach (DataRow dr in dtUser2.Rows)
            {
                string x = dr["ROOM_NO"].ToString();
                comboBoxRoom.Items.Add(x);
            }



        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doctor_service_panel_Load(object sender, EventArgs e)
        {
            load();
        }

        private string getPatientId(string x)
        {
            DBAccess dbobjy = new DBAccess();
            DataTable dtUsery = new DataTable();
            string query = ("SELECT ID FROM USER_INFO WHERE NAME='" + x + "'");
            dbobjy.readDatathroughAdapter(query, dtUsery);
            if (dtUsery.Rows.Count == 1)
            {
                return dtUsery.Rows[0]["ID"].ToString();
            }
            else
            {
                return "";
            }
        }

        private string getServiceId(string x)
        {
            DBAccess dbobjy = new DBAccess();
            DataTable dtUsery = new DataTable();
            string query = ("SELECT ID FROM SERVICES WHERE NAME='" + x + "'");
            dbobjy.readDatathroughAdapter(query, dtUsery);
            if (dtUsery.Rows.Count == 1)
            {
                return dtUsery.Rows[0]["ID"].ToString();
            }
            else
            {
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            string paitentId="";
            string serviceId = "";
            int isPaid = 0;
            string name = comboBoxName.SelectedItem.ToString();
            string service = comboBoxService.SelectedItem.ToString();
            paitentId = getPatientId(name);
            serviceId = getServiceId(service);
            string query = "INSERT INTO CUS_SER(CID,SID,IS_PAID) VALUES (@paitentId,@serviceId,@isPaid)";
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@paitentId", paitentId);
            insertCommand.Parameters.AddWithValue("@serviceId", serviceId);
            insertCommand.Parameters.AddWithValue("@isPaid", isPaid);
            int success = dba.executeQuery(insertCommand);
            if (success == 1) {
                MessageBox.Show("Service Added");
            }
            else {
                MessageBox.Show("Failed!");
            }
        }

        private string getRoomId(string x)
        {
            DBAccess dbobjy = new DBAccess();
            DataTable dtUsery = new DataTable();
            string query = ("SELECT ID FROM ROOM WHERE ROOM_NO='" + x + "'");
            dbobjy.readDatathroughAdapter(query, dtUsery);
            if (dtUsery.Rows.Count == 1)
            {
                return dtUsery.Rows[0]["ID"].ToString();
            }
            else
            {
                return "";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            string patientId = "";
            string roomId = "";
            int isPaid = 0;
            int totalDays = 1;
            DateTime date = DateTime.Today;

            string name = comboBoxName.SelectedItem.ToString();
            string room = comboBoxRoom.SelectedItem.ToString();
            patientId = getPatientId(name);
            roomId = getServiceId(room);
            string query = "INSERT INTO CUS_ROOM(RID,CID,IS_PAID,TOTAL_DAYS,IN_DATE) VALUES (@RID,@CID,@IS_PAID,@TOTAL_DAYS,@IN_DATE)";
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@RID", roomId);
            insertCommand.Parameters.AddWithValue("@CID", patientId);
            insertCommand.Parameters.AddWithValue("@IS_PAID", isPaid);
            insertCommand.Parameters.AddWithValue("@TOTAL_DAYS", totalDays);
            insertCommand.Parameters.AddWithValue("@IN_DATE", date);
            int success = dba.executeQuery(insertCommand);
            if (success == 1)
            {
                MessageBox.Show("Service Added");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

        }
    }
}
