﻿using System;
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
    public partial class patient_appointment_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser, dtUser1;
        string time, dname, get_d_id, get_customer_id, get_time;
        private string user_id;
        string c, d, e, f, g, h, i, j;
        int set_time, id;
        public patient_appointment_panel()
        {
            InitializeComponent();
        }
        public patient_appointment_panel(string x)
        {
            InitializeComponent();
            user_id = x;
        }

        private void btn_change_time_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }

        private void btn_patient_ap_submit_Click(object sender, EventArgs e)
        {
            if (cbox_patient_doc_time.SelectedIndex > 0 || cbox_patient_doc_time.SelectedIndex == 0)
            {
                dbobj = new DBAccess();
                dtUser = new DataTable();
                dbobj.closeConn();
                string t = cbox_patient_doc_time.SelectedItem.ToString();
                timeset(t);
                cbox_patient_doc_name.Items.Clear();
                Doctor_ID();
                Customer_ID();
                int is_cancel = 0;
                int is_paid = 0;
                string query = "INSERT INTO CUS_DOC(DID,CID,TIME,DATE,IS_CANCEL,IS_PAID) VALUES (@DID,@CID,@TIME,@DATE,@IS_CANCEL,@IS_PAID)";
                SqlCommand insertCommand = new SqlCommand(query);
                insertCommand.Parameters.AddWithValue("@DID", get_d_id);
                insertCommand.Parameters.AddWithValue("@CID", get_customer_id);
                insertCommand.Parameters.AddWithValue("@TIME", set_time);
                insertCommand.Parameters.AddWithValue("@DATE", dateTimePicker1.Value);
                insertCommand.Parameters.AddWithValue("@IS_CANCEL", is_cancel);
                insertCommand.Parameters.AddWithValue("@IS_PAID", is_paid);
                int success = dbobj.executeQuery(insertCommand);
                MessageBox.Show("Successfully Confirmed.");
                dbobj.closeConn();
                cbox_patient_doc_name.Items.Clear();
                cbox_patient_doc_time.Items.Clear();
                cbox_patient_doc_name.Text = "";
                cbox_patient_doc_time.Text = "";
                dateTimePicker1.Value = DateTime.Today;
                //patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
                cbox_patient_doc_name.Items.Clear();
                cbox_patient_doc_time.Items.Clear();
                cbox_patient_doc_name.Text = "";
                cbox_patient_doc_time.Text = "";
                //btn_refresh.Visible = true;
                load();
                timeget(dname);
            }
            else
            {

                MessageBox.Show("Please select doctor");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
            }
        }

        private void btn_change_time_Click_1(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }

        private void btn_cancel_appointment_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_cancel_panel"))
            {
                patient_app_cancel_panel p_a_t_c_p = new patient_app_cancel_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_cancel_panel"].BringToFront();
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
            string query4 = "SELECT TIME FROM CUS_DOC WHERE DID = '" + get_d_id + "' AND DATE = '" + dateTimePicker1.Value + "' ORDER BY TIME ASC";
            dbobj.readDatathroughAdapter(query4, dtUser1);
            if (dtUser1.Rows.Count >= 1)
            {
                int count = dtUser1.Rows.Count;
                int[] arr = new int[8];
                for (int m = 0; m < 8; m++)
                {
                    arr[m] = m + 1;
                }
                for (int k = 0; k < count; k++)
                {
                    get_time = dtUser1.Rows[k]["TIME"].ToString();
                    int a = Convert.ToInt32(get_time);
                    for (int l = 1; l <= 8; l++)
                    {
                        if (arr[l - 1] == a)
                        {
                            arr[l - 1] = 0;
                        }
                    }
                }

                foreach (int i in arr)
                {
                    check(i);
                }
            }
            else
            {
                cbox_patient_doc_time.Items.AddRange(new object[] { c, d, e, f, g, h, i, j });
            }

            dbobj.closeConn();

        }
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


            ///////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\\\\\\\\\\\\\\\\
            //dbobj = new DBAccess();
            //dtUser = new DataTable();
            //timeget();
        }

        private void btn_doctor_select_Click(object sender, EventArgs e)
        {
            if (cbox_patient_doc_name.SelectedIndex > 0 || cbox_patient_doc_name.SelectedIndex == 0)
            {
                cbox_patient_doc_time.Items.Clear();
                dname = cbox_patient_doc_name.SelectedItem.ToString();
                timeget(dname);
            }
            else
            {
                MessageBox.Show("Please select doctor");
                patient_panel.Instance_4.PnlContainer_4.Controls["patient_appointment_panel"].BringToFront();
            }
        }
        public void timeset(string t)
        {
            if (t == c)
            {
                set_time = 1;
            }
            else if (t == d)
            {
                set_time = 2;
            }
            else if (t == e)
            {
                set_time = 3;
            }
            else if (t == f)
            {
                set_time = 4;
            }
            else if (t == g)
            {
                set_time = 5;
            }
            else if (t == h)
            {
                set_time = 6;
            }
            else if (t == i)
            {
                set_time = 7;
            }
            else if (t == j)
            {
                set_time = 8;
            }
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
            string query4 = "SELECT ID FROM USER_INFO WHERE USER_ID = '" + user_id + "'";
            SqlDataReader select_info3 = dbobj.readDatathroughReader(query4);
            while (select_info3.Read())
            {
                get_customer_id = select_info3["ID"].ToString();
            }
            dbobj.closeConn();

        }


        private void patient_appointment_panel_Load(object sender, EventArgs e)
        {
            load();
        }
    }

}
