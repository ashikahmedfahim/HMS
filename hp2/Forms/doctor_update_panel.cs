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
    public partial class doctor_update_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        public doctor_update_panel()
        {
            InitializeComponent();
        }

        public void load() {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = ("SELECT * FROM USER_INFO WHERE USER_ID = '" + login.getId() + "'");
            dbobj.readDatathroughAdapter(query, dtUser);
            if (dtUser.Rows.Count == 1)
            {
                textBox1.Text = login.getId();
                textBox2.Text = dtUser.Rows[0]["NAME"].ToString();
                textBox3.Text = dtUser.Rows[0]["PHONE"].ToString();
                textBox4.Text = dtUser.Rows[0]["ADDRESS"].ToString();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void doctor_update_panel_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text=="" && textBox6.Text=="") {
                MessageBox.Show("Fields cannot be empty");
            }
            else {
                if (textBox5.Text!="") {
                    string query = "UPDATE USER_INFO  SET PHONE='"+textBox5.Text+"' WHERE USER_ID = '"+login.getId() + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    int res = dbobj.executeQuery(updateCommand);
                    if (res==1) {
                        MessageBox.Show("Update Successful");
                    }
                
                }
                if (textBox6.Text!="") {
                    string query = "UPDATE USER_INFO  SET ADDRESS='" + textBox6.Text + "' WHERE USER_ID = '" + login.getId() + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    int res = dbobj.executeQuery(updateCommand);
                    if (res == 1)
                    {
                        MessageBox.Show("Update Successful");
                    }
                }
                textBox5.Text = "";
                textBox6.Text = "";
                load();

            }
        }
    }
}
