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
        public void load()
        {
            dbobj = new DBAccess();
            dtUser = new DataTable();
            string query = "select * from USER_INFO WHERE USER_ID= '" + id + "'";
            SqlDataReader select_info = dbobj.readDatathroughReader(query);
            while (select_info.Read())
            {

                name = select_info["NAME"].ToString();
                phone = select_info["PHONE"].ToString();
                address = select_info["ADDRESS"].ToString();
            }

            lbl_puserid.Text = id;
            lbl_pname.Text = name;
            lbl_pphone_no.Text = phone;
            lbl_paddress.Text = address;
            dbobj.closeConn();
        }
        private void patient_details_panel_Load(object sender, EventArgs e)
        {
            load();

        }

        private void btn_info_change_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient__info_change"))
            {
                patient__info_change p_i_c = new patient__info_change();
                p_i_c.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_i_c);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient__info_change"].BringToFront();
            load();

        }

        private void btn_password_change_Click(object sender, EventArgs e)
        {
            if (!patient_panel.Instance_4.PnlContainer_4.Controls.ContainsKey("patient_password_change"))
            {
                patient_password_change p_p_c = new patient_password_change();
                p_p_c.Dock = DockStyle.Fill;
                patient_panel.Instance_4.PnlContainer_4.Controls.Add(p_p_c);
            }
            patient_panel.Instance_4.PnlContainer_4.Controls["patient_password_change"].BringToFront();
            load();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load();
        }
    }


}
