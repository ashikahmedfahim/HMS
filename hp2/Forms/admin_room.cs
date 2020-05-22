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
    public partial class admin_room : UserControl
    {
        DBAccess da;
        DataTable dt;
        DBAccess dBAccess;
        DataTable datatable;
        string id;
        string isFree;
        string na;
        public admin_room()
        {
            InitializeComponent();
            dBAccess = new DBAccess();
            datatable = new DataTable();
        }

        private void admin_room_Load(object sender, EventArgs e)
        {
            get();
            cmbAvailability1.Items.Clear();
            cmbAvailability1.Items.Add("Available");
            cmbAvailability1.Items.Add("Not Available");

            cmbAvailability2.Items.Clear();
            cmbAvailability2.Items.Add("Available");
            cmbAvailability2.Items.Add("Not Available");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "";
            txtCharge.Text = "";
            cmbAvailability1.Text = "";
            cmbAvailability1.Items.Clear();
            cmbAvailability1.Items.Add("Available");
            cmbAvailability1.Items.Add("Not Available");

            cmbAvailability2.Text = "";
            cmbAvailability2.Items.Clear();
            cmbAvailability2.Items.Add("Available");
            cmbAvailability2.Items.Add("Not Available");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "" && txtCharge.Text == "" && cmbAvailability1.SelectedItem == null)
            {
                MessageBox.Show("Please Fillup the TextBox.");
            }
            else
            {
                if (cmbAvailability1.SelectedItem == null)
                {
                    MessageBox.Show("This Room is already exist");
                }
                else
                {
                    string roomno = txtRoomNo.Text;
                    string charge = txtCharge.Text;
                    string selectItem = cmbAvailability1.SelectedItem.ToString();
                    if (selectItem == "Available")
                    {
                        isFree = "1";
                    }
                    else
                    {
                        isFree = "0";
                    }
                    string query = "INSERT INTO ROOM(ROOM_NO,CHARGE,IS_FREE) VALUES (@roomno,@charge,@isFree)";
                    SqlCommand insertCommand = new SqlCommand(query);
                    insertCommand.Parameters.AddWithValue("@roomno", roomno);
                    insertCommand.Parameters.AddWithValue("@charge", charge);
                    insertCommand.Parameters.AddWithValue("@isFree", isFree);
                    int success = dBAccess.executeQuery(insertCommand);
                    MessageBox.Show("Inserted.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "" || txtCharge.Text == "" || cmbAvailability1.Text == "")
            {
                MessageBox.Show("Select a Room First.");
            }
            else
            {
                string query = "DELETE FROM ROOM WHERE ID = '" + id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                dBAccess.executeQuery(deleteCommand);
                MessageBox.Show("Deleted.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "" && txtCharge.Text == "" && cmbAvailability1.Text == "")
            {
                MessageBox.Show("Select a Room First.");
            }
            else
            {
                if (txtNewCharge.Text == "" || cmbAvailability2.Items == null)
                {
                    MessageBox.Show("Please Add a New Charge and Select an Option.");
                }
                else
                {
                    string charge = txtNewCharge.Text;
                    string selectItemm = cmbAvailability2.SelectedItem.ToString();
                    if (selectItemm == "Available")
                    {
                        na = "1";
                    }
                    else
                    {
                        na = "0";
                    }
                    string query = "UPDATE ROOM SET CHARGE='" + @charge + "', IS_FREE= '" + @na + "' WHERE [ID]='" + id + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    updateCommand.Parameters.AddWithValue("@charge", @charge);
                    updateCommand.Parameters.AddWithValue("@na", @na);
                    dBAccess.executeQuery(updateCommand);
                    MessageBox.Show("Updated.");
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoomNo.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCharge.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string isFreeValue = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (isFreeValue == "1")
            {
                cmbAvailability1.Items.Clear();
                cmbAvailability1.Text = "Available";
            }
            else
            {
                cmbAvailability1.Items.Clear();
                cmbAvailability1.Text = "Not Available";
            }
        }
        public void get()
        {
            da = new DBAccess();
            dt = new DataTable();
            string query = "select * from ROOM";
            da.readDatathroughAdapter(query, dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Visible = false;
            da.closeConn();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            get();
            txtRoomNo.Text = "";
            txtNewCharge.Text = "";
            txtCharge.Text = "";

            cmbAvailability1.Text = "";
            cmbAvailability1.Items.Clear();
            cmbAvailability1.Items.Add("Available");
            cmbAvailability1.Items.Add("Not Available");

            cmbAvailability2.Text = "";
            cmbAvailability2.Items.Clear();
            cmbAvailability2.Items.Add("Available");
            cmbAvailability2.Items.Add("Not Available");
        }
    }
}
