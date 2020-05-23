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
    public partial class admin_patient : UserControl
    {
        DBAccess da;
        DataTable dt;
        DBAccess da1;
        DataTable dt1;
        DBAccess da2;
        DataTable dt2;
        DBAccess da3;
        string patientID;
        string doctorID;
        string id;
        string date, cancel, payment;

        public admin_patient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_patient_Load(object sender, EventArgs e)
        {
            get();
        }
        public void get()
        {
            da = new DBAccess();
            dt = new DataTable();
            string query = "select * from USER_INFO WHERE USER_ID like 'p%'";
            da.readDatathroughAdapter(query, dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[6].Visible = false;
            da.closeConn();
        }
        public void GetPatient()
        {
            da1 = new DBAccess();
            string query = "SELECT * FROM CUS_DOC WHERE CID = '" + patientID + "' AND DID = '" + id + "'";
            SqlDataReader reader = da1.readDatathroughReader(query);
            while (reader.Read())
            {
                date = reader["DATE"].ToString();
                cancel = reader["IS_CANCEL"].ToString();
                payment = reader["IS_PAID"].ToString();
            }
            da1.closeConn();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            abc();
            GetPatient();

            lblDate.Text = date;

            if (cancel == "1")
            {
                lblCancel.Text = "Canceled";
            }
            else
            {
                lblCancel.Text = "Allowed";
            }
            if (payment == "1")
            {
                lblPayment.Text = "Paid";
            }
            else
            {
                lblPayment.Text = "Not Paid";
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patientID = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbDoctorName.Items.Clear();
            GetDoctor();
        }
        public void GetDoctor()
        {
            da2 = new DBAccess();
            dt2 = new DataTable();
            string query = ("SELECT A.NAME FROM USER_INFO A, CUS_DOC B WHERE B.CID = '" + patientID + "' AND A.ID = B.DID");
            da2.readDatathroughAdapter(query, dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                cmbDoctorName.Items.Add(dr["NAME"].ToString());
            }
            da2.closeConn();
        }
        public void abc()
        {
            da3 = new DBAccess();
            string name = cmbDoctorName.SelectedItem.ToString();
            string query = "SELECT ID FROM USER_INFO WHERE NAME = '" + name + "'";
            da3 = new DBAccess();
            SqlDataReader reader = da3.readDatathroughReader(query);
            while (reader.Read())
            {
                id = reader["ID"].ToString();
            }
            da3.closeConn();
        }
    }
}