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
    public partial class doctor_schedule_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        private string date;
        private string getDid;
        private string[] getCid= new string[8];
        private string[] timeVal=new string[8];
        private string user_id;

        public doctor_schedule_panel()
        {
            InitializeComponent();
        }

        public doctor_schedule_panel(string x)
        {
            InitializeComponent();
            user_id = x;
        }


        private string getNameData(int x)
        {
            DBAccess dbobj1 = new DBAccess();
            DataTable dtUser1 = new DataTable();
            string cidx = dtUser.Rows[x]["CID"].ToString();
            getCid[x] = cidx;
            string query3x = ("SELECT NAME FROM USER_INFO WHERE ID = '" + cidx + "'");
            dbobj1.readDatathroughAdapter(query3x, dtUser1);
            if (dtUser1.Rows.Count == 1)
            {
                return dtUser1.Rows[0]["NAME"].ToString();
            }
            else
            {
                return "";
            }
        }

        private string getDoctorId()
        {
            DBAccess dbobjy = new DBAccess();
            DataTable dtUsery = new DataTable();
            string query = ("SELECT ID FROM USER_INFO WHERE USER_ID='" + user_id + "'");
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
        private string getPatientName(string x)
        {
            DBAccess dbobjx = new DBAccess();
            DataTable dtUserx = new DataTable();
            string query = "SELECT NAME FROM USER_INFO WHERE ID='" + x + "'";
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

        public void load()
        {

            dbobj = new DBAccess();
            dtUser = new DataTable();
            string x = "";
            string query = "SELECT CID,TIME FROM CUS_DOC WHERE DID = '" + getDoctorId() + "' AND DATE  = '"+dateTimePicker1.Value.ToString()+"'";
            dbobj.readDatathroughAdapter(query, dtUser);
            int i = 0;
            foreach (DataRow dr in dtUser.Rows)
            {
                x = dr["CID"].ToString();
                string y = getPatientName(x);
                i++;
            }



            DBAccess dbobj11 = new DBAccess();
            DataTable dtUser11 = new DataTable();
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query2 = ("SELECT * FROM USER_INFO WHERE USER_ID = '" + user_id + "'");
            dbobj11.readDatathroughAdapter(query2, dtUser11);
            if (dtUser11.Rows.Count == 1)
            {
                string id= dtUser11.Rows[0]["ID"].ToString();
                textBox1.Text = dtUser11.Rows[0]["TIMING"].ToString();
                date = dateTimePicker1.Value.ToString();
                getDid = id;
                string query22 = ("SELECT * FROM CUS_DOC WHERE DID = '" + id + "' AND DATE = '"+date+"' AND IS_CANCEL = '"+"0"+"' ORDER BY  TIME ASC");
                dbobj.readDatathroughAdapter(query22, dtUser);
                if (dtUser.Rows.Count >= 1) {
                    int count = dtUser.Rows.Count;
                    for (int i1=0;i1<count;i1++) { 
                        string z= dtUser.Rows[i1]["TIME"].ToString();
                        timeVal[i]=z;
                    }
                    textBox2.Text = getNameData(0);
                    textBox3.Text= dtUser.Rows[0]["TIME"].ToString();
                    count--;
                    if (count >0) {
                        textBox4.Text = getPatientName(x);
                        textBox11.Text = dtUser.Rows[1]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox5.Text = getPatientName(x);
                        textBox12.Text = dtUser.Rows[2]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox6.Text = getPatientName(x);
                        textBox13.Text = dtUser.Rows[3]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox7.Text = getPatientName(x);
                        textBox14.Text = dtUser.Rows[4]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox8.Text = getPatientName(x);
                        textBox15.Text = dtUser.Rows[5]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox9.Text = getPatientName(x);
                        textBox16.Text = dtUser.Rows[6]["TIME"].ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        textBox10.Text = getPatientName(x);
                        textBox17.Text = dtUser.Rows[7]["TIME"].ToString();
                        count--;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void doctor_schedule_panel_Load(object sender, EventArgs e)
        {
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCancel(int x) {
            DBAccess dba = new DBAccess();
            string query = "UPDATE CUS_DOC  SET IS_CANCEL='" + "1" + "' WHERE CID  = '" + getCid[x] + "' AND DID = '" + getDid + "'  AND TIME ='" + timeVal[x] + "' AND DATE = '" + date + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            int res = dba.executeQuery(updateCommand);
            if (res == 1)
            {
                MessageBox.Show("Appointment Cancelled");
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            updateCancel(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateCancel(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateCancel(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateCancel(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateCancel(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateCancel(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateCancel(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateCancel(7);
        }
    }
}
