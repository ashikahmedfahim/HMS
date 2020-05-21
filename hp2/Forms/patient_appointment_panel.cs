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
    public partial class patient_appointment_panel : UserControl
    {
        DBAccess dbobj;
        DataTable dtUser;
        string time, name;
        public patient_appointment_panel()
        {
            InitializeComponent();
        }

        private void btn_change_time_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }

        private void btn_change_time_Click_1(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_time_change_panel"))
            {
                patient_app_time_change_panel p_a_t_c_p = new patient_app_time_change_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_time_change_panel"].BringToFront();
        }

        private void btn_cancel_appointment_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_app_cancel_panel"))
            {
                patient_app_cancel_panel p_a_t_c_p = new patient_app_cancel_panel();
                p_a_t_c_p.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_a_t_c_p);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_app_cancel_panel"].BringToFront();
        }
        //public void timeget()
        //{

        //    //string query2 = ("SELECT TIMING FROM USER_INFO WHERE NAME='" + name + "'");
        //    //dbobj.readDatathroughAdapter(query2, dtUser);
        //    //foreach (DataRow dr2 in dtUser.Rows)
        //    //{
        //    //   // cbox_patient_doc_time.Items.Add(dr2["TIMING"].ToString());
        //    //    string a=dr2["TIMING"].ToString();
        //    //    int b = a[0];
        //    //}
        //    //dbobj.closeConn();
        //    dbobj = new DBAccess();
        //    dtUser = new DataTable();
        //    string query2 = "SELECT TIMING FROM USER_INFO WHERE NAME = '" + name + "'";
        //    SqlDataReader select_info = dbobj.readDatathroughReader(query2);
        //    while (select_info.Read())
        //    {
        //        time = select_info["TIMING"].ToString();
        //    }

        //    int b = time[0];
        //    string c = b.ToString() + ":00" + b.ToString() + ":15";
        //    string d = b.ToString() + ":15" + b.ToString() + ":30";
        //    string e = b.ToString() + ":30" + b.ToString() + ":45";
        //    string f = b.ToString() + ":45" + (b + 1).ToString() + ":00";
        //    string g = (b + 1).ToString() + ":00" + (b + 1).ToString() + ":15";
        //    string h = (b + 1).ToString() + ":15" + (b + 1).ToString() + ":30";
        //    string i = (b + 1).ToString() + ":30" + (b + 1).ToString() + ":45";
        //    string j = (b + 1).ToString() + ":45" + (b + 2).ToString() + ":00";

        //    cbox_patient_doc_time.Items.AddRange(new object[] { c, d, e, f, g, h, i, j });
        //    dbobj.closeConn();
        //}
        public void load()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = ("SELECT NAME FROM USER_INFO WHERE USER_ID LIKE 'd%' order by USER_ID");
            dbobj.readDatathroughAdapter(query, dtUser);
            foreach (DataRow dr in dtUser.Rows)
            {
                cbox_patient_doc_name.Items.Add(dr["NAME"].ToString());
            }
            dbobj.closeConn();

            ///////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\\\\\\\\\\\\\\\\
            //dbobj = new DBAccess();
            //dtUser = new DataTable();
            //timeget();
        }

        private void btn_doctor_select_Click(object sender, EventArgs e)
        {
            name = cbox_patient_doc_name.SelectedItem.ToString();
        }

        private void patient_appointment_panel_Load(object sender, EventArgs e)
        {
            load();
        }
    }
    
}
