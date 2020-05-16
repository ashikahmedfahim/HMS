using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hp2.Etest;
using System.Data;
using System.Data.SqlClient;

namespace hp2
{
    public partial class signup : UserControl
    {
        DBAccess dbobj = new DBAccess();
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_MouseHover(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.Aqua;
        }

        private void btn_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.White;
        }

        private void btn_cancel_signup_MouseHover(object sender, EventArgs e)
        {
            btn_cancel_signup.BackColor = Color.Red;
        }

        private void btn_cancel_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel_signup.BackColor = Color.White;

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string user_id = txt_box_userid.Text;
            string name = txt_box_name.Text;
            string password = txt_box_password.Text;
            string phone = txt_box_phone.Text;
            string address = txt_box_address.Text;
            if (user_id == "" || name == "" || password == "" || phone == "" || address == "")
            {
                MessageBox.Show("Please Enter All The Informations");
            }
            else
            {
                string result = txt_box_userid.Text.Substring(0, 1);
                if (result == "p")
                {
                    string query = "INSERT INTO USER_INFO(USER_ID,NAME,PASSWORD,PHONE,ADDRESS) VALUES (@user_id,@name,@password,@phone,@address)";
                    SqlCommand insertCommand = new SqlCommand(query);
                    insertCommand.Parameters.AddWithValue("@user_id", user_id);
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@address", address);
                    int success = dbobj.executeQuery(insertCommand);
                    if (success == 1)
                    {
                        login.genUserId = user_id;
                        MessageBox.Show("SignUp Successful");
                        if (!Form1.Instance.PnlContainer.Controls.ContainsKey("patient_panel"))
                        {
                            patient_panel pp = new patient_panel();
                            pp.Dock = DockStyle.Fill;
                            Form1.Instance.PnlContainer.Controls.Add(pp);
                        }
                        Form1.Instance.PnlContainer.Controls["patient_panel"].BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Fail inserted");
                        txt_box_userid.Text = "";
                        txt_box_name.Text = "";
                        txt_box_password.Text = "";
                        txt_box_phone.Text = "";
                        txt_box_address.Text = "";
                        Form1.Instance.PnlContainer.Controls["signup"].BringToFront();

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Informations As Directed");
                    txt_box_userid.Text = "";
                    txt_box_name.Text = "";
                    txt_box_password.Text = "";
                    txt_box_phone.Text = "";
                    txt_box_address.Text = "";
                    Form1.Instance.PnlContainer.Controls["signup"].BringToFront();
                }
            }
        }

        private void btn_cancel_signup_Click(object sender, EventArgs e)
        {
            txt_box_userid.Text = "";
            txt_box_name.Text = "";
            txt_box_password.Text = "";
            txt_box_phone.Text = "";
            txt_box_address.Text = "";
            Form1.Instance.PnlContainer.Controls["firstpage"].BringToFront();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void txt_box_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
