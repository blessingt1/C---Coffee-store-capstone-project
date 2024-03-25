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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeetleCafDB.mdf;Integrated Security=True";
        //4 main classes
        SqlConnection con = new SqlConnection(constr);
        SqlCommand com;
        SqlDataAdapter adapt;
        SqlDataReader dreader;

        public int num =1;

        //methods
        
        //Read Drinks Method
        public void ReadDrinks(string sql)
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
                    lstProductList.Items.Add(dreader.GetValue(2) + " " + dreader.GetValue(1) + "          " + "\t"  + "R" + dreader.GetValue(4));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Read Food Method
        public void ReadFood(string sql)
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
                    lstProductList.Items.Add(dreader.GetValue(1) + "\t" + "\t" + "R" + dreader.GetValue(3));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //Insert method
        public void InsertToCart(string sql)
        {
            //try block
            try
            {
                //opening the connection 
                con.Open();
                //inst adapt
                adapt = new SqlDataAdapter();
                //inst com
                com = new SqlCommand(sql, con);
                //insert command
                adapt.InsertCommand = com;
                //insert command and execute non query
                adapt.InsertCommand.ExecuteNonQuery();
                //closing the connection 
                con.Close();
            }//catching thrown exceptions 
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Read method, to read to the the cart list 
        public void ReadToCartList(string sql)
        {

            //try block
            try
            {
                //opening the connection 
                con.Open();
                //inst com
                com = new SqlCommand(sql, con);
                //dreader
                dreader = com.ExecuteReader();
                //while loop to read
                while (dreader.Read())
                {
                    lstCartReport.Items.Add(dreader.GetValue(1) + "\t" + "R" + dreader.GetValue(2));
                }
                con.Close();
            }//catch block
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Remove from cart list and cart table
        public void RemoveFromCart(string sql)
        {
            //try block
            try
            {
                //opening the connection 
                con.Open();
                //inst adapt
                adapt = new SqlDataAdapter();
                //inst com 
                com = new SqlCommand(sql, con);
                //delete command
                adapt.DeleteCommand = com;
                //execute non query
                adapt.DeleteCommand.ExecuteNonQuery();
                //closing the connection 
                con.Close();
            }//catching exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //Display method
        public void OrderReport(string sql)
        {
            //try block
            try
            {
                //opening the connection
                con.Open();
                //inst adapt
                adapt = new SqlDataAdapter();
                //inst com
                com = new SqlCommand(sql, con);
                //select command
                adapt.SelectCommand = com;
                //data set
                DataSet ds = new DataSet();
                //filling
                adapt.Fill(ds, "Varsity cup champs 2023");
                //datasource
                dataGridView1.DataSource = ds;
                //datamember
                dataGridView1.DataMember = "Varsity cup champs 2023";
                //closing the connection 
                con.Close();

            }//catching the exception
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void frmOrder_Load(object sender, EventArgs e)
        {
            //disabling the relevent conrtrols 
            btnGoToCart.Enabled = false;
            btnAddToCart.Enabled = false;

            
           
        }
        /*
        private void pbSteamingBeverages_Click(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();


            //Displaying a list of steaming beverages
            ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Steaming beverage'");
        }

        private void pbChilledBeverages_Click(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of chilled beverages
            ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Chilled Beverage'");
        }

        private void pbSandwhich_Click(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of sandwiches
            ReadFood("SELECT * FROM Food WHERE FoodType = 'Sandwich'");
        }

        private void pbBakedTreats_Click(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of sandwiches
            ReadFood("SELECT * FROM Food WHERE FoodType = 'Baked treat'");
        }*/






        private void btnAddToCart_Click(object sender, EventArgs e)
        {
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
        }

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pbSteamingBeverages_Click_1(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();


            //Displaying a list of steaming beverages
            ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Steaming beverage'");
        }

        private void pbSandwhich_Click_1(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of sandwiches
            ReadFood("SELECT * FROM Food WHERE FoodType = 'Sandwich'");
        }

        private void pbChilledBeverages_Click_1(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of chilled beverages
            ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Chilled Beverage'");
        }

        private void pbBakedTreats_Click_1(object sender, EventArgs e)
        {
            //clearing the list box
            lstProductList.Items.Clear();

            //Displaying a list of sandwiches
            ReadFood("SELECT * FROM Food WHERE FoodType = 'Baked treat'");
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            //exception handling for cases where the user is trying to add an item to the cart without having selected any items
            if (lstProductList.SelectedIndex == -1)
            {
                btnAddToCart.Enabled = false;
            }
            else
            {
                //product number
                Random rand = new Random();
                num = rand.Next(1, 99);

                //R position
                int rPosition = lstProductList.SelectedItem.ToString().IndexOf("R");


                //the name
                string name = lstProductList.SelectedItem.ToString().Substring(0, (rPosition - 1));
                //the price
                string stringPrice = lstProductList.SelectedItem.ToString().Substring((rPosition + 1), 5);  //R is at index 30
                decimal decPrice = decimal.Parse(stringPrice);


                //MessageBox.Show("Name:  " + name + "\n" + "Price: " + stringPrice + " num: " + num);

                //adding items to our cart
                InsertToCart($"INSERT INTO AddToCart VALUES('{num.ToString()}','{name}',{decPrice.ToString()})"); //PRODUCT NUMBER, NAME, PRICE

                //incrementing num 
                //   num = num + 1;

                //enabling the relevent controls
                btnGoToCart.Enabled = true;
            }
        }

        private void btnGoToCart_Click_1(object sender, EventArgs e)
        {
            // Set the cart tab as the selected tab
            tabControl1.SelectedTab = tabPage2;
        }

        private void lstProductList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //enabling the relevant controls
            btnAddToCart.Enabled = true;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //clearing the cart list
            lstCartReport.Items.Clear();

            //Showing the customer the items that they have ordered
            ReadToCartList("SELECT * FROM AddToCart");

            //if the cart is empty 
            if (lstCartReport.Items.Count == 0)
            {
                lblEmpty.Text = "Your cart is empty, please add items to proceed";
                btnProceedToPayment.Enabled = false;
                btnRemoveItems.Enabled = false;
            }
            else
            {
                lblEmpty.Text = "";
                btnProceedToPayment.Enabled = true;
                btnRemoveItems.Enabled = true;
            }
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            // Set the payment tab as the selected tab
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            // Set the order tab as the selected tab
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            //Displaying the report of the order that has been made
            OrderReport("SELECT * FROM AddToCart");


            //Check this code for an empty order
            /*
            if (dataGridView1.RowCount > 0)
            {
                // The data grid has been filled with data
            }
            else
            {
                // The data grid is empty
            }*/
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
