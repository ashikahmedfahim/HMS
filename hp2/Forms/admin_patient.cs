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
            dt1 = new DataTable();
            string query = "SELECT * FROM CUS_DOC WHERE CID = '" + patientID + "' AND DID = '" + id + "'";
            da1.readDatathroughAdapter(query, dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            da1.closeConn();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            abc();
            GetPatient();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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