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
    public partial class admin_details : UserControl
    {
        DBAccess da;
        DataTable dt;
        string name, address, phone;
        public admin_details()
        {
            InitializeComponent();
        }

        private void details_admin_Load(object sender, EventArgs e)
        {
            da = new DBAccess();
            dt = new DataTable();
            string query = "select * from USER_INFO WHERE USER_ID like 'a%'";
            SqlDataReader select_info = da.readDatathroughReader(query);
            while (select_info.Read())
            {

                name = select_info["NAME"].ToString();
                phone = select_info["PHONE"].ToString();
                address = select_info["ADDRESS"].ToString();
            }

            lblName.Text = name;
            lblAddress.Text = address;
            lblPhone.Text = phone;
            da.closeConn();
        }
    }
}
