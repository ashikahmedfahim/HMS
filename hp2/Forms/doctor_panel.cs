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
    public partial class doctor_panel : UserControl
    {
        static doctor_panel _obj3;

        public static doctor_panel Instance_3
        {
            get
            {
                if (_obj3 == null)
                {
                    _obj3 = new doctor_panel();
                }
                return _obj3;
            }
        }
        public Panel PnlContainer_3
        {
            get { return doctor_panel_rightSide; }
            set { doctor_panel_rightSide = value; }
        }
        public doctor_panel()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!doctor_panel.Instance_3.PnlContainer_3.Controls.ContainsKey("doctor_schedule_panel"))
            {
                doctor_schedule_panel dsp = new doctor_schedule_panel();
                dsp.Dock = DockStyle.Fill;
                doctor_panel.Instance_3.PnlContainer_3.Controls.Add(dsp);
            }
            doctor_panel.Instance_3.PnlContainer_3.Controls["doctor_schedule_panel"].BringToFront();
        }


        private void doctor_panel_Load(object sender, EventArgs e)
        {

                _obj3 = this;
            doctor_home_panel dhp = new doctor_home_panel();
                dhp.Dock = DockStyle.Fill;
            doctor_panel_rightSide.Controls.Add(dhp);
            doctor_panel_rightSide.Controls["doctor_home_panel"].BringToFront();

        }

        private void doctor_panel_rightSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _obj3 = this;
            doctor_home_panel dhp = new doctor_home_panel();
            dhp.Dock = DockStyle.Fill;
            doctor_panel_rightSide.Controls.Add(dhp);
            doctor_panel_rightSide.Controls["doctor_home_panel"].BringToFront();

        }

        private void update_but_Click(object sender, EventArgs e)
        {
            _obj3 = this;
            doctor_update_panel dup = new doctor_update_panel();
            dup.Dock = DockStyle.Fill;
            doctor_panel_rightSide.Controls.Add(dup);
            doctor_panel_rightSide.Controls["doctor_update_panel"].BringToFront();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            _obj3 = this;
            doctor_schedule_panel dsp = new doctor_schedule_panel();
            dsp.Dock = DockStyle.Fill;
            doctor_panel_rightSide.Controls.Add(dsp);
            doctor_panel_rightSide.Controls["doctor_schedule_panel"].BringToFront();

        }

        private void doctor_panel_rightSide_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
