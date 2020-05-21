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
    public partial class admin_service : UserControl
    {
        DBAccess da;
        DBAccess dBAccess;
        DataTable datatable;
        DataTable dt;
        string id;
        public admin_service()
        {
            InitializeComponent();
            dBAccess = new DBAccess();
            datatable = new DataTable();
        }

        private void admin_service_Load(object sender, EventArgs e)
        {
            get();
        }

        private void btn_ser_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtCharge.Text == "")
            {
                MessageBox.Show("Please Fillup the TextBox.");
            }
            else
            {
                string name = txtName.Text;
                string charge = txtCharge.Text;
                string query = "INSERT INTO SERVICES(NAME,CHARGE) VALUES (@name,@charge)";
                SqlCommand insertCommand = new SqlCommand(query);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@charge", charge);
                int success = dBAccess.executeQuery(insertCommand);
                MessageBox.Show("Inserted.");
                dBAccess.closeConn();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            get();
            clear();
            txtNewCharge.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCharge.Text == "")
            {
                MessageBox.Show("Select a Service First.");
            }
            else
            {
                string query = "DELETE FROM SERVICES WHERE ID = '" + id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                dBAccess.executeQuery(deleteCommand);
                MessageBox.Show("Deleted.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtCharge.Text == "")
            {
                MessageBox.Show("Select a Service First.");
            }
            else
            {
                if (txtNewCharge.Text == "")
                {
                    MessageBox.Show("Please Insert a New Charge.");
                }
                else
                {
                    string charge = txtNewCharge.Text;
                    string query = "UPDATE SERVICES SET CHARGE='" + @charge + "' WHERE [ID]='" + id + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    updateCommand.Parameters.AddWithValue("@charge", @charge);
                    dBAccess.executeQuery(updateCommand);
                    MessageBox.Show("Updated.");
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCharge.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        public void get()
        {
            da = new DBAccess();
            dt = new DataTable();
            string query = "select * from SERVICES";
            da.readDatathroughAdapter(query, dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Visible = false;
            da.closeConn();
        }
        public void clear()
        {
            txtName.Text = "";
            txtCharge.Text = "";
        }
    }
}
