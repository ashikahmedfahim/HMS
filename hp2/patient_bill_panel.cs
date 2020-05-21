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
        public void Service_Charge()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            dbobj.closeConn();
            string query = "select SUM(C.CHARGE)CHARGE from USER_INFO A,CUS_SER B,SERVICES C WHERE A.USER_ID= '" + login.getId() + "' AND A.ID=B.CID AND B.SID=C.ID";
            SqlDataReader select_info = dbobj.readDatathroughReader(query);
            while (select_info.Read())
            {
                id = select_info["CHARGE"].ToString();
            }
            dbobj.closeConn();
            lbl_service_charge.Text = id;
        }

        public void R_charge()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            dbobj.closeConn();
            string query2 = "select SUM(C.CHARGE)CHARGE from USER_INFO A,CUS_ROOM B,ROOM C WHERE A.USER_ID= '" + login.getId() + "' AND A.ID=B.CID AND B.RID=C.ID";
            SqlDataReader select_info2 = dbobj.readDatathroughReader(query2);
            while (select_info2.Read())
            {
                id2 = select_info2["CHARGE"].ToString();
            }
            dbobj.closeConn();
            lbl_room_charge.Text = id2;

        }

        private void patient_bill_panel_Load(object sender, EventArgs e)
        {
            Service_Charge();
            R_charge();
            int total_charge = int.Parse(id) + int.Parse(id2)+500;
            lbl_total_charge.Text = total_charge.ToString();
        }
    }
}
