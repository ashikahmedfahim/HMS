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
    public partial class Test : UserControl
    {
        DBAccess da, da1, da2, da3;
        DataTable dt2, dt3;
        string id, did;
        string timing, cid, time;
        string patientID;
        public Test()
        {
            InitializeComponent();
        }
        public Test(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView2.DataSource = null;
            da = new DBAccess();
            string query = "select* from USER_INFO WHERE USER_ID = '" + id + "'";
            SqlDataReader reader = da.readDatathroughReader(query);
            while (reader.Read())
            {
                timing = reader["TIMING"].ToString();
            }
            lblTiming.Text = timing;
            da.closeConn();

            //getdid();
        }
        public void getdid()
        {
            da1 = new DBAccess();
            string query = "SELECT * FROM USER_INFO WHERE USER_ID = '" + id + "'";
            da1 = new DBAccess();
            SqlDataReader reader = da1.readDatathroughReader(query);
            while (reader.Read())
            {
                did = reader["ID"].ToString();
            }
            da1.closeConn();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getdid();
            GetPidTime();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patientID = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

            da3 = new DBAccess();
            dt3 = new DataTable();
            string query = "SELECT * FROM USER_INFO WHERE  ID = '" + patientID + "'";
            da3.readDatathroughAdapter(query, dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            da3.closeConn();
        }
        public void GetPidTime()
        {
            da2 = new DBAccess();
            dt2 = new DataTable();
            string query = "SELECT * FROM CUS_DOC WHERE  DID = '" + did + "' AND DATE = '" + dateTimePicker1.Value + "'";
            da2.readDatathroughAdapter(query, dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            da2.closeConn();
        }
    }
}
