﻿using System;
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
    public partial class doctor_service_panel : UserControl
    {

        DBAccess dbobj;
        DataTable dtUser;
        public doctor_service_panel()
        {
            InitializeComponent();
        }

        private void load() {
            dbobj = new DBAccess();
            dtUser = new DataTable();

        
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doctor_service_panel_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
