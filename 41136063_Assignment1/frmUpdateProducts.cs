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
    public partial class frmUpdateProducts : Form
    {
        public frmUpdateProducts()
        {
            InitializeComponent();
        }

        //Public Update price variables 
        public decimal updateBevPrice;
        public decimal updateFoodPice;
        public string DNAME;
        public string FNAME;

        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeetleCafDB.mdf;Integrated Security=True";
        //4 main classes
        SqlConnection con = new SqlConnection(constr);
        SqlCommand com;
        SqlDataAdapter adapt;
        SqlDataReader dreader;

        //methods

        //Read Drinks Method
        public void ReadDRINKS(string sql)
        {
            //try block
            try
            {
                //opening the connection
                con.Open();
                //inst com
                com = new SqlCommand(sql, con);
                //dreader and execute reader
                dreader = com.ExecuteReader();
                //while loop to read the items
                while (dreader.Read())
                {
                    lstUpdateList.Items.Add(dreader.GetValue(2) + " " + dreader.GetValue(1) + ",          " + "\t" + "R" + dreader.GetValue(4));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Read Food Method
        public void ReadFOOD(string sql)
        {
            //try block
            try
            {
                //opening the connection
                con.Open();
                //inst com
                com = new SqlCommand(sql, con);
                //dreader and execute reader
                dreader = com.ExecuteReader();
                //while loop to read the items
                while (dreader.Read())
                {
                    lstUpdateList.Items.Add(dreader.GetValue(1) + ", " + "\t" + "\t" + "R" + dreader.GetValue(3));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUPDATED_Click(object sender, EventArgs e)
        {
            //assingning the bev update variable
            //updateBevPrice = decimal.Parse(txtBUp.Text);
            if (decimal.TryParse(txtBUp.Text, out updateBevPrice))
            {
                errorProvider1.SetError(txtBUp, "");
            }
            else
            {
                errorProvider1.SetError(txtBUp, "Invalid price entered");
            }

            //selected beverage name 
            int comPos = lstUpdateList.SelectedItem.ToString().IndexOf(",");
            DNAME = lstUpdateList.SelectedItem.ToString().Substring(0, (comPos));
        }

        private void btnUpdateFPRICE_Click(object sender, EventArgs e)
        {
            //assingning the bev update variable
            //updateFoodPice = decimal.Parse(txtFUp.Text);
            if (decimal.TryParse(txtFUp.Text, out updateFoodPice))
            {
                errorProvider1.SetError(txtFUp, "");
            }
            else
            {
                errorProvider1.SetError(txtFUp, "Invalid price entered");
            }

            //selected food name 
            int comPos = lstUpdateList.SelectedItem.ToString().IndexOf(",");
            FNAME = lstUpdateList.SelectedItem.ToString().Substring(0, (comPos));
        }

        private void frmUpdateProducts_Load(object sender, EventArgs e)
        {
            //clearing the listbox
            lstUpdateList.Items.Clear();


            //Display all products that are provided
            //Heading
            lstUpdateList.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstUpdateList.Items.Add("\n");

            //Heading
            lstUpdateList.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");
        }
    }
}
