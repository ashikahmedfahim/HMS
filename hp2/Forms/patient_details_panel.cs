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
    public partial class patient_details_panel : UserControl
    {
        string id;
       // string user_id;
        string name;
        string phone;
        string address;
       // DBAccess dBAccess;
        DBAccess dbobj;
        DataTable dtUser;

        public patient_details_panel(string id)
        {
            InitializeComponent();
            //dBAccess = new DBAccess();
            this.id = id;
            System.Console.WriteLine(id);
        }
        public patient_details_panel()
        {
            InitializeComponent();
        }

        private void patient_details_panel_Load(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            //string name = lbl_pname.Text;
            //string userid = lbl_puserid.Text;
            //string phone = lbl_pphone_no.Text;
            //string address = lbl_paddress.Text;
            string query = "select * from USER_INFO WHERE USER_ID= '" + id + "'";
            // SqlCommand insertCommand = new SqlCommand(query);
            SqlDataReader select_info = dbobj.readDatathroughReader(query);
            while (select_info.Read())
            {
                 //user_id = select_info["UER_ID"].ToString();
                 name = select_info["NAME"].ToString();
                 phone = select_info["PHONE"].ToString();
                 address = select_info["ADDRESS"].ToString();
            }

            lbl_puserid.Text = id;
            lbl_pname.Text = name;
            //lbl_puserid.Text = user_id;
            lbl_pphone_no.Text = phone;
            lbl_paddress.Text = address;
            
        }
    }


}
