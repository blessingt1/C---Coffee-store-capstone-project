using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Signing the contract
using System.Data.SqlClient;

namespace _41136063_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Name and Surname: Blessing Baloyi
        //Student number: 41136063


        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeetleCafDB.mdf;Integrated Security=True";
        //4 main classes
        SqlConnection con = new SqlConnection(constr);
        SqlCommand com;
        SqlDataAdapter adapt;
        SqlDataReader dreader;

        //methods
        public void Connect()
        {
            try
            {
                //opening the connection 
                con.Open();
                //checking the connection state
                if(con.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("Connection to database failed");
                }
                //closing the connection
                con.Close();
            }//catching thrown exceptions
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Leaving the appication 
            Application.Exit();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Connecting to the database
            Connect();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hiding the relevent controls
            pictureBox1.Hide();
            lblWelcome.Hide();
            lblHeading.Hide();


            //showing the order form
            frmOrder fo = new frmOrder();
            fo.MdiParent = this;
            fo.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hiding the relevent controls
            pictureBox1.Hide();
            lblWelcome.Hide();
            lblHeading.Hide();

            //Showing the staff log in page 
            frmStaffLogIn fsl = new frmStaffLogIn();
            fsl.MdiParent = this;
            fsl.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ordersRecievedToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
