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
        DataTable dtUser, dtUser1, dtUser2,dtUser3,dtUser4;
        string time, dname, get_d_id, get_customer_id, get_time;
        string a;
        string c, d, e, f, g, h, i, j;
        string doc;
        public void load()
        {
            dbobj = new DBAccess();
            dtUser3 = new DataTable();
            cbox_patient_doc_name.Items.Clear();
            cbox_patient_doc_time.Items.Clear();
            Customer_ID();
            string query2 = ("SELECT DID FROM CUS_DOC WHERE CID='" + get_customer_id + "'");
            dbobj.readDatathroughAdapter(query2, dtUser3);
            foreach (DataRow dr in dtUser3.Rows)
            {
                string did=dr["DID"].ToString();
                int did2 = Convert.ToInt32(did);

               dtUser4 = new DataTable();
                string query = ("SELECT A.NAME FROM USER_INFO A ,CUS_DOC B WHERE A.ID=B.DID AND B.DID='" + did + "'");
                dbobj.readDatathroughAdapter(query, dtUser4);

                foreach (DataRow dr2 in dtUser4.Rows)
                {
                    if(doc!= dr2["NAME"].ToString())
                    {
                        doc = dr2["NAME"].ToString();
                        cbox_patient_doc_name.Items.Add(dr2["NAME"].ToString());
                        break;
                    }

                    //cbox_patient_doc_name.Items.Add(dr2["NAME"].ToString());
                    break;
                }
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
        public void timeselect()
        {
            if (cbox_patient_doc_time.SelectedItem.ToString()==c)
            {
                a = "1";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==d)
            {
                a = "2";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==e)
            {
                a = "3";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==f)
            {
                a = "4";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==g)
            {
                a = "5";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==h)
            {
                a = "6";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==i)
            {
                a = "7";
            }else if (cbox_patient_doc_time.SelectedItem.ToString()==j)
            {
                a = "8";
            }
        }
        private void btn_patient_ap_delete_Click_1(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser2 = new DataTable();
            // string a = cbox_patient_doc_time.SelectedItem.ToString();
            timeselect();
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

        private void btn_doctor_select_Click_1(object sender, EventArgs e)
        {
            if (cbox_patient_doc_name.SelectedIndex > 0 || cbox_patient_doc_name.SelectedIndex == 0)
            {
                cbox_patient_doc_time.Items.Clear();
                dname = cbox_patient_doc_name.SelectedItem.ToString();
                cbox_patient_doc_time.Items.Clear();
                timeget(dname);
                maintimeset();
            }
            else
            {
                MessageBox.Show("Please select doctor");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_cancel_panel"].BringToFront();
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            load();
            cbox_patient_doc_name.Text = "";
            cbox_patient_doc_time.Text = "";

            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_appointment_panel"))
            {
                patient_appointment_panel p_a_p = new patient_appointment_panel();
                p_a_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
        }

        private void patient_app_cancel_panel_Load_1(object sender, EventArgs e)
        {
            load();
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
        public void timeget(string name)
        {
            cbox_patient_doc_time.Items.Clear();
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query2 = "SELECT TIMING FROM USER_INFO WHERE NAME = '" + name + "'";
            SqlDataReader select_info = dbobj.readDatathroughReader(query2);
            while (select_info.Read())
            {
                time = select_info["TIMING"].ToString();
            }
            string a = time;
            string a2 = a[0].ToString();
            int b = int.Parse(a2);
            c = b.ToString() + ":00" + "--" + b.ToString() + ":15";
            d = b.ToString() + ":15" + "--" + b.ToString() + ":30";
            e = b.ToString() + ":30" + "--" + b.ToString() + ":45";
            f = b.ToString() + ":45" + "--" + (b + 1).ToString() + ":00";
            g = (b + 1).ToString() + ":00" + "--" + (b + 1).ToString() + ":15";
            h = (b + 1).ToString() + ":15" + "--" + (b + 1).ToString() + ":30";
            i = (b + 1).ToString() + ":30" + "--" + (b + 1).ToString() + ":45";
            j = (b + 1).ToString() + ":45" + "--" + (b + 2).ToString() + ":00";
            //   cbox_patient_doc_time.Items.AddRange(new object[] { c, d, e, f, g, h, i, j });
            dbobj.closeConn();
            maintimeset();
        }

        public void check(int id2)
        {
            if (id2 == 1)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { c });
            }
            else if (id2 == 2)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { d });
            }
            else if (id2 == 3)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { e });
            }
            else if (id2 == 4)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { f });
            }
            else if (id2 == 5)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { g });
            }
            else if (id2 == 6)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { h });
            }
            else if (id2 == 7)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { i });
            }
            else if (id2 == 8)
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { j });
            }
            //else
            //{
            //    cbox_patient_doc_time.Items.AddRange(new object[] { c, d, e, f, g, h, i, j });
            //}
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
                string a=dr["TIME"].ToString();
                int a2 = Convert.ToInt32(a);

                if(a2==1)
                {
                    check(a2);
                }if(a2==2)
                {
                    check(a2);
                }if(a2==3)
                {
                    check(a2);
                }if(a2==4)
                {
                    check(a2);
                }if(a2==5)
                {
                    check(a2);
                }if(a2==6)
                {
                    check(a2);
                }if(a2==7)
                {
                    check(a2);
                }if(a2==8)
                {
                    check(a2);
                }
               // cbox_patient_doc_time.Items.Add(dr["TIME"].ToString());
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
