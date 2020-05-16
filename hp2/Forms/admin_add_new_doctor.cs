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
    public partial class admin_add_new_doctor : UserControl
    {
        DBAccess dbobj = new DBAccess();
        public admin_add_new_doctor()
        {
            InitializeComponent();
        }

        private void admin_add_new_doctor_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoctorID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtTiming.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string user_id = txtDoctorID.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string timing = txtTiming.Text;
            string password = txtPassword.Text;
            string cPassword = txtConfirmPassword.Text;

            if (user_id == "" || name == "" || phone == "" || timing == "" || address == "" || password == "" || cPassword == "")
            {
                MessageBox.Show("Please Enter All The Informations");
            }
            else
            {
                string result = txtDoctorID.Text.Substring(0, 1);
                if (result == "d" && password == cPassword)
                {
                    string query = "INSERT INTO USER_INFO(USER_ID,NAME,PASSWORD,PHONE,ADDRESS,TIMING) VALUES (@user_id,@name,@password,@phone,@address,@timing)";
                    SqlCommand insertCommand = new SqlCommand(query);
                    insertCommand.Parameters.AddWithValue("@user_id", user_id);
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@phone", phone);
                    insertCommand.Parameters.AddWithValue("@address", address);
                    insertCommand.Parameters.AddWithValue("@timing", timing);
                    int success = dbobj.executeQuery(insertCommand);
                    if (success == 1)
                    {
                        MessageBox.Show("Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Fail inserted");
                    }
                }
                else
                {
                    MessageBox.Show("Password dose not match..");
                }
            }
        }
    }
}
