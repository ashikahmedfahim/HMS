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
    public partial class Forget_pass_panel : UserControl
    {
        DBAccess dbobj = new DBAccess();
        public Forget_pass_panel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lgn = new login();
                lgn.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lgn);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Please, Enter All the Informations");
            }
            else if (textBox2.TextLength < 11) {
                MessageBox.Show("Please, Enter Valid Phone Number");
            }
            else {
                string user_id = textBox1.Text;
                string phone = textBox2.Text;
                string password = textBox3.Text;
                string query = "UPDATE USER_INFO  SET PASSWORD ='" + password + "' WHERE USER_ID = '" + user_id + "' AND PHONE = '" + phone + "'";
                SqlCommand updateCommand = new SqlCommand(query);
                int res = dbobj.executeQuery(updateCommand);
                if (res == 1)
                {
                    MessageBox.Show("Update Successful");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else {
                    MessageBox.Show("User Id  or Phone no does not match");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }
    }
}
