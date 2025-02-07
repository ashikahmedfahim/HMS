﻿using System;
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
    public partial class login : UserControl
    {
        DBAccess dbobj;
        DataTable dtUsers;
        private static string genUserId;
        public login()
        {
            InitializeComponent();
            txt_box_login_userid.Text = "";
            txt_box_login_password.Text = "";
            loadData();
        }

        public void loadData() {
            dbobj = new DBAccess();
            dtUsers = new DataTable();
        }

        public static void setId(string x)
        {
            genUserId = x;
        }

        public static string getId()
        {
            return genUserId;
        }
        

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            loadData();
            if (txt_box_login_userid.Text=="" || txt_box_login_password.Text=="")
            {
                MessageBox.Show("Please Enter User Id and Password");
                txt_box_login_userid.Text = "";
                txt_box_login_password.Text = "";
                Form1.Instance.PnlContainer.Controls["login"].BringToFront();
            }
            else
            {
                string user_id = txt_box_login_userid.Text;
                string password = txt_box_login_password.Text;
                string query = "SELECT * FROM USER_INFO WHERE USER_ID = '"+ user_id +"' AND PASSWORD = '"+ password +"'";

                dbobj.readDatathroughAdapter(query,dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    setId(user_id); 
                    dbobj.closeConn();
                    string result = txt_box_login_userid.Text.Substring(0, 1);
                    if (result == "a")
                    {
                        if (!Form1.Instance.PnlContainer.Controls.ContainsKey("admin_panel"))
                        {
                            admin_panel ap = new admin_panel();
                            ap.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainer.Controls.Add(ap);
                        }
                        Form1.Instance.PnlContainer.Controls["admin_panel"].BringToFront();

                    }

                    else if (result == "p")
                    {
                        if (!Form1.Instance.PnlContainer.Controls.ContainsKey("patient_panel"))
                        {
                            patient_panel pp = new patient_panel(txt_box_login_userid.Text);
                            pp.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainer.Controls.Add(pp);
                        }
                        Form1.Instance.PnlContainer.Controls["patient_panel"].BringToFront();
                        txt_box_login_userid.Text = "";
                        txt_box_login_password.Text = "";

                    }

                    else if (result == "d")
                    {
                        if (!Form1.Instance.PnlContainer.Controls.ContainsKey("doctor_panel"))
                        {
                            doctor_panel dp = new doctor_panel(txt_box_login_userid.Text);
                            dp.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainer.Controls.Add(dp);
                        }
                        Form1.Instance.PnlContainer.Controls["doctor_panel"].BringToFront();
                        txt_box_login_userid.Text = "";
                        txt_box_login_password.Text = "";
                    }

                }
                else {
                    MessageBox.Show("User Id or Password is Incorrect");
                    txt_box_login_userid.Text = "";
                    txt_box_login_password.Text = "";
                }

            }




            
        }

        private void btn_logIn_MouseHover(object sender, EventArgs e)
        {
            btn_logIn.BackColor = Color.Aqua;

        }

        private void btn_logIn_MouseLeave(object sender, EventArgs e)
        {
            btn_logIn.BackColor = Color.White;
        }

        private void btn_cancel_login_Click(object sender, EventArgs e)
        {
            txt_box_login_userid.Text = "";
            txt_box_login_password.Text = "";
            Form1.Instance.PnlContainer.Controls["firstpage"].BringToFront();
        }

        private void btn_cancel_login_MouseHover(object sender, EventArgs e)
        {
            btn_cancel_login.BackColor = Color.Red;

        }

        private void btn_cancel_login_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel_login.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Forget_pass_panel"))
            {
                Forget_pass_panel fpp = new Forget_pass_panel();
                fpp.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(fpp);
            }
            Form1.Instance.PnlContainer.Controls["Forget_pass_panel"].BringToFront();
        }
    }
}
