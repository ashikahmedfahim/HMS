//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace hp2
//{
//    public partial class patient_bill_panel : UserControl
//    {
//        string id, id2,id3,id4;
//        string user_id;
//        string get_customer_id;
//        //string name;
//        //string phone;
//        //string address;
//        //// DBAccess dBAccess;
//        DBAccess dbobj;
//        DataTable dtUser;
//        public patient_bill_panel()
//        {
//            InitializeComponent();
//        }
//        public patient_bill_panel(string x)
//        {
//            InitializeComponent();
//            user_id = x;
//        }

//       public void Customer_ID()
//       {
//                dbobj = new DBAccess();
//                dtUser = new DataTable();
//                string query4 = "SELECT ID FROM USER_INFO WHERE USER_ID = '" + user_id + "'";
//                SqlDataReader select_info3 = dbobj.readDatathroughReader(query4);
//                while (select_info3.Read())
//                {
//                    get_customer_id = select_info3["ID"].ToString();
//                }
//                dbobj.closeConn();

//       }

//        public void Service_Charge()
//        {
//            dbobj = new DBAccess();
//            dtUser = new DataTable();
//            dbobj.closeConn();
//            string query = "select SUM(C.CHARGE)CHARGE from USER_INFO A,CUS_SER B,SERVICES C WHERE A.USER_ID= '" + login.getId() + "' AND A.ID=B.CID AND B.SID=C.ID";
//            SqlDataReader select_info = dbobj.readDatathroughReader(query);
//            while (select_info.Read())
//            {
//                id = select_info["CHARGE"].ToString();
//            }
//            dbobj.closeConn();
//            lbl_service_charge.Text = id;
//        }

//        public void R_charge()
//        {
//            dbobj = new DBAccess();
//            dtUser = new DataTable();
//            dbobj.closeConn();
//            string query2 = "select SUM(C.CHARGE)CHARGE from USER_INFO A,CUS_ROOM B,ROOM C WHERE A.USER_ID= '" + login.getId() + "' AND A.ID=B.CID AND B.RID=C.ID ";
//            SqlDataReader select_info2 = dbobj.readDatathroughReader(query2);
//            while (select_info2.Read())
//            {
//                id2 = select_info2["CHARGE"].ToString();
//            }
//            dbobj.closeConn();
//            lbl_room_charge.Text = id2;

//        }

//        private void btn_refresh_Click(object sender, EventArgs e)
//        {
//            load();
//        }
//        public void load()
//        {
//            Service_Charge();
//            R_charge();
//            if (id == "")
//            {
//                id3 = "0";
//                lbl_service_charge.Text = "0";
//            }
//            if (id != "")
//            {
//                id3 = id;
//            }
//            if (id2 == "")
//            {
//                id4 = "0";
//                lbl_room_charge.Text = "0";
//            }
//            if (id2 != "")
//            {
//                id4 = id2;
//            }
//            int total_charge = int.Parse(id3) + int.Parse(id4) + 500;
//            lbl_total_charge.Text = total_charge.ToString();
//        }
//        private void patient_bill_panel_Load(object sender, EventArgs e)
//        {
//            load();
//        }
//    }
//}

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
    public partial class patient_bill_panel : UserControl
    {
        string id, id2;
        string id3, id4;
        string user_id;
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
        public patient_bill_panel(string x)
        {
            InitializeComponent();
            user_id = x;
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
            //lbl_service_charge.Text = id;
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
            //lbl_room_charge.Text = id2;

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            Service_Charge();
            R_charge();
            if (id == "")
            {
                id3 = "0";
                lbl_service_charge.Text = "0";
            }
            if (id != "")
            {
                id3 = id;
            }
            if (id2 == "")
            {
                id4 = "0";
                lbl_room_charge.Text = "0";
            }
            if (id2 != "")
            {
                id4 = id2;
            }
            lbl_service_charge.Text = id3;
            lbl_room_charge.Text = id4;
            int total_charge = int.Parse(id3) + int.Parse(id4) + 500;
            lbl_total_charge.Text = total_charge.ToString();
        }
        private void patient_bill_panel_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}

