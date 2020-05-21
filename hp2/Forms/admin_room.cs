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
        public admin_room()
        {
            InitializeComponent();
            dBAccess = new DBAccess();
            datatable = new DataTable();
        }

        private void admin_room_Load(object sender, EventArgs e)
        {
            string query = "select * from ROOM";
            dBAccess.readDatathroughAdapter(query, datatable);
            dataGridView.DataSource = datatable;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomNo.Text = "";
            txtCharge.Text = "";
            txtAvailability.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string roomno = txtRoomNo.Text;
            string charge = txtCharge.Text;
            string isFree = txtAvailability.Text;
            string query = "INSERT INTO ROOM(ROOM_NO,CHARGE,IS_FREE) VALUES (@roomno,@charge,@isFree)";
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@roomno", roomno);
            insertCommand.Parameters.AddWithValue("@charge", charge);
            insertCommand.Parameters.AddWithValue("@isFree", isFree);
            int success = dBAccess.executeQuery(insertCommand);
            MessageBox.Show("Inserted.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ROOM WHERE ID = '" + id + "'";
            SqlCommand deleteCommand = new SqlCommand(query);
            dBAccess.executeQuery(deleteCommand);
            MessageBox.Show("Deleted.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string charge = txtNewCharge.Text;
            string na = txtNewAvailability.Text;
            string query = "UPDATE ROOM SET CHARGE='" + @charge + "', IS_FREE= '" + @na + "' WHERE [ID]='" + id + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@charge", @charge);
            updateCommand.Parameters.AddWithValue("@na", @na);
            dBAccess.executeQuery(updateCommand);
            MessageBox.Show("Updated.");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRoomNo.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCharge.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAvailability.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
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
    }
}
