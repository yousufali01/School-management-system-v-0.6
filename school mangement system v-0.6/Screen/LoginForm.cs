
using school_mangement_system_v_0._6.Screen.Templetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_mangement_system_v_0._6.Screen
{
    public partial class LoginForm : TemplateForm
    {
        private object UserNameTextBox;


        //public bool UserNameTextBox { get; private set; }

        // public bool IsFormValid { get; private set; }
        // public bool UserText { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text =="12345")
            {
                this.Hide();
                DashboardForm frm = new DashboardForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Password Or Username not Currect.");
            }
                


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
