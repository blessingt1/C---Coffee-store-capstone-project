using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41136063_Assignment1
{
    public partial class frmStaffLogIn : Form
    {
        public frmStaffLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string StaffLoginpassord = " C212ASS1";

            //implementing the error provider
            if(txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter a username");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }

            if(txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Please enter a password");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }


            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter a username");
                errorProvider1.SetError(txtPassword, "Please enter a password");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
                errorProvider1.SetError(txtPassword, "");
            }


            




            //validating the password
            if (txtPassword.Text != StaffLoginpassord)
            {
                lblError.Text = "Incorrect password ";
            }
            else
            {
                this.Close();

                //Granting access and opening the staff form
                frmStaff fs = new frmStaff();
                fs.Show();

                //resetting the error label
                lblError.Text = "";
            }
                
            
        }

        private void frmStaffLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
