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
    public partial class admin_doctor : UserControl
    {
        static admin_doctor _obj;
        DataTable dt;
        DBAccess da;
        DBAccess dBAccess;
        string id;
        public admin_doctor()
        {
            InitializeComponent();
            dBAccess = new DBAccess();
        }
        public static admin_doctor Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new admin_doctor();
                }
                return _obj;
            }
        }
        public Panel panel_ad_right
        {
            get { return panel_ad_right; }
            set { panel_ad_right = value; }
        }

        private void admin_doctors_Load(object sender, EventArgs e)
        {
            get();
        }

        private void btn_edit_doctor_info_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_add_new_doctor_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_new_doctor_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            get();
            clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDoctorID.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTiming.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorID.Text == "" && txtName.Text == "" && txtPhone.Text == "" && txtAddress.Text == "" && txtTiming.Text == "")
            {
                MessageBox.Show("Select a Doctor First.");
            }
            else
            {
                if (txtNewTiming.Text == "")
                {
                    MessageBox.Show("Please Insert a New Timing.");
                }
                else
                {
                    string newTiming = txtNewTiming.Text;
                    string query = "UPDATE USER_INFO SET TIMING='" + @newTiming + "' WHERE [ID]='" + id + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    updateCommand.Parameters.AddWithValue("@newTiming", newTiming);
                    dBAccess.executeQuery(updateCommand);
                    MessageBox.Show("Updated.");
                }
            }
        }
        public void clear()
        {
            txtDoctorID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtTiming.Text = "";
            txtNewTiming.Text = "";
        }
        public void get()
        {
            da = new DBAccess();
            dt = new DataTable();
            string query = "select * from USER_INFO WHERE USER_ID like 'd%'";
            da.readDatathroughAdapter(query, dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[3].Visible = false;
            da.closeConn();
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            if (!admin_panel.Instance_2.PnlContainer_2.Controls.ContainsKey("admin_add_new_doctor"))
            {
                admin_add_new_doctor ad_a_n_d = new admin_add_new_doctor();
                ad_a_n_d.Dock = DockStyle.Fill;
                admin_panel.Instance_2.PnlContainer_2.Controls.Add(ad_a_n_d);
            }
            admin_panel.Instance_2.PnlContainer_2.Controls["admin_add_new_doctor"].BringToFront();
        }
    }
}
