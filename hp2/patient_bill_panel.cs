using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp2
{
    public partial class patient_bill_panel: UserControl
    {
        //string id;
        //// string user_id;
        //string name;
        //string phone;
        //string address;
        //// DBAccess dBAccess;
        //DBAccess dbobj;
        //DataTable dtUser;
        public patient_bill_panel()
        {
            InitializeComponent();
        }

        private void patient_bill_panel_Load(object sender, EventArgs e)
        {
            //dbobj = new DBAccess();
            //dtUser = new DataTable();
            //string query = "select * from USER_INFO WHERE USER_ID= '" + id + "'";
            //SqlDataReader select_info = dbobj.readDatathroughReader(query);
            //while (select_info.Read())
            //{

            //    name = select_info["NAME"].ToString();
            //    phone = select_info["PHONE"].ToString();
            //    address = select_info["ADDRESS"].ToString();
            //}

            //lbl_puserid.Text = id;
            //lbl_pname.Text = name;
            //lbl_pphone_no.Text = phone;
            //lbl_paddress.Text = address;
        }
    }
}
