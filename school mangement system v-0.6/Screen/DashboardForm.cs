using school_mangement_system_v_0._6.Screen.Templetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_mangement_system_v_0._6.Screen
{
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutStudentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
