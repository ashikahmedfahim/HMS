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
    public partial class patient_bill_panel: UserControl
    {
        string id,id2;
        //// string user_id;
        //string name;
        //string phone;
        //string address;
        //// DBAccess dBAccess;
        DBAccess dbobj;
        DataTable dtUser;
        public patient_bill_panel()
        {
            InitializeComponent();
        }

        private void patient_bill_panel_Load(object sender, EventArgs e)
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = "select a.ID from USER_INFO, WHERE USER_ID= '" + login.getId() + "'";
            SqlDataReader select_info = dbobj.readDatathroughReader(query);
            while (select_info.Read())
            {
                id = select_info["ID"].ToString();
            }
            dbobj.closeConn();
            lbl_service_charge.Text = id;

            //string idd = id;
            //string query2 = "select SID from CUS_SER WHERE CID= '" + idd.ToString() + "'";
            //SqlDataReader select_info2 = dbobj.readDatathroughReader(query2);
            //while (select_info2.Read())
            //{
            //    id2 = select_info["SID"].ToString();
            //}
            //dbobj.closeConn();
            //lbl_service_charge.Text = id;
            //lbl_room_charge.Text = id2;

        }
    }
}
