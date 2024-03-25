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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

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
                    lstStaffReport.Items.Add(dreader.GetValue(2) + " " + dreader.GetValue(1) + ",          " + "\t" + "R" + dreader.GetValue(4));
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
                    lstStaffReport.Items.Add(dreader.GetValue(1) + ", " + "\t" + "\t" + "R" + dreader.GetValue(3));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //Insert product method
        public void InsertProduct(string sql)
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
                MessageBox.Show("Product inserted successfully");
            }//catching thrown exceptions 
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Update product method
        public void UpdateProduct(string sql)
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
                adapt.UpdateCommand = com;
                //insert command and execute non query
                adapt.UpdateCommand.ExecuteNonQuery();
                //closing the connection 
                con.Close();
            }//catching thrown exceptions 
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Delete product method
        public void DeleteProduct(string sql)
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
                adapt.DeleteCommand = com;
                //insert command and execute non query
                adapt.DeleteCommand.ExecuteNonQuery();
                //closing the connection 
                con.Close();
            }//catching thrown exceptions 
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






        private void frmStaff_Load(object sender, EventArgs e)
        {/*
            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {/*
            //Opening the insert method
            frmInsertProduct fip = new frmInsertProduct();
            fip.ShowDialog();

            //Inserting new beverge items into the beverage table
            InsertProduct($"INSERT INTO Drinks VALUES('{fip.BID}','{fip.BNAME}','{fip.BSIZE}','{fip.BTYPE}','{fip.BPRICE}')");

            //Message
            MessageBox.Show("Product inserted successfully");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {/*
            //isnt frmUpdateProducts
            frmUpdateProducts fu = new frmUpdateProducts();
            fu.ShowDialog();

            //Update operations food
            UpdateProduct("UPDATE Drinks SET BeveragePrice = '" + fu.updateBevPrice + "' WHERE BerageName = '" + fu.DNAME + "'");

            //Message
            MessageBox.Show("Product updated successfully");

            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {/*

            //inst frmInsertProduct
            //frmInsertProduct fip = new frmInsertProduct();

            //if nothing is selected 
            if(lstStaffReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product that you want to delete from the list box");
            }
            
                int comPos = lstStaffReport.SelectedItem.ToString().IndexOf(",");
                string BevName = lstStaffReport.SelectedItem.ToString().Substring(0, (comPos));

                //Delete operations
                DeleteProduct("DELETE FROM Drinks WHERE BerageName = '" + BevName + "'");


                //clearing the listbox
                lstStaffReport.Items.Clear();


                //Display all products that are provided
                //Heading
                lstStaffReport.Items.Add("Beverages");
                //list of beverages
                ReadDRINKS("SELECT * FROM Drinks");

                //making space
                lstStaffReport.Items.Add("\n");

                //Heading
                lstStaffReport.Items.Add("Food");
                //list of beverages
                ReadFOOD("SELECT * FROM Food");*/
        }

        private void btnInsertFood_Click(object sender, EventArgs e)
        {/*
            
            //Opening the insert method
            frmInsertProduct fip = new frmInsertProduct();
            fip.ShowDialog();

            //Inserting new food items into the food table
            InsertProduct($"INSERT INTO Food VALUES('{fip.FID}','{fip.FNAME}','{fip.FTYPE}','{fip.FPRICE}')");

            //Message
            MessageBox.Show("Product inserted successfully");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {/*
            //if nothing is selected 
            if (lstStaffReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product that you want to delete from the list box");
            }


            //inst frmInsertProduct
            frmInsertProduct fip = new frmInsertProduct();

            int comPos = lstStaffReport.SelectedItem.ToString().IndexOf(",");
            string FDName = lstStaffReport.SelectedItem.ToString().Substring(0, (comPos));

            //Delete operations
            DeleteProduct("DELETE FROM Food WHERE FoodName = '" + FDName + "'");



            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {/*
            //isnt frmUpdateProducts
            frmUpdateProducts fu = new frmUpdateProducts();
            fu.ShowDialog();


            //Update operations food
            UpdateProduct("UPDATE Food SET FoodPrice = '" + fu.updateFoodPice + "' WHERE FoodName = '" + fu.FNAME + "'");

            //Message
            MessageBox.Show("Product updated successfully");

            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            //enabling an disabling the buttons
            if(lstStaffReport.Items.Count == 0)
            {
                //btnDeleteBev.Enabled = false;
                //btnDeleteFood.Enabled = false;
                btnUpdateBeverage.Enabled = false;
                btnUpdateFood.Enabled = false;
            }
            else
            {
                //btnDeleteBev.Enabled = true;
                //btnDeleteFood.Enabled = true;
                btnUpdateBeverage.Enabled = true;
                btnUpdateFood.Enabled = true;

            }
            if(lstStaffReport.SelectedIndex == -1)
            {
                //btnDeleteBev.Enabled = false;
                //btnDeleteFood.Enabled = false;
                btnUpdateBeverage.Enabled = true;
                btnUpdateFood.Enabled = true;
                btnInsertFood.Enabled = true;
                btnInserBev.Enabled = true;
            }
            else
            {
                //btnDeleteBev.Enabled = true;
                //btnDeleteFood.Enabled = true;
                btnUpdateBeverage.Enabled = false;
                btnUpdateFood.Enabled = false;
                btnInsertFood.Enabled = false;
                btnInserBev.Enabled = false;
            }



            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //focussing on the insert bev control
            btnInserBev.Focus();

            //disabling the relevant controls
            btnDeleteBev.Enabled = false;
            btnDeleteFood.Enabled = false;
        }

        private void btnInsertFood_Click_1(object sender, EventArgs e)
        {
            //this.Hide();

            //Opening the insert method
            frmInsertProduct fip = new frmInsertProduct();
            fip.btnInsertBevItem.Enabled = false;
            fip.ShowDialog();

            //Inserting new food items into the food table
            InsertProduct($"INSERT INTO Food VALUES('{fip.FID}','{fip.FNAME}','{fip.FTYPE}','{fip.FPRICE}')");

            //Message
            MessageBox.Show("Product inserted successfully");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //this.Show();
        }

        private void btnInserBev_Click(object sender, EventArgs e)
        {

            //this.Hide();

            //Opening the insert method
            frmInsertProduct fip = new frmInsertProduct();

            fip.btnInsertFoodItem.Enabled = false;
            fip.ShowDialog();

            //Inserting new beverge items into the beverage table
            InsertProduct($"INSERT INTO Drinks VALUES('{fip.BID}','{fip.BNAME}','{fip.BSIZE}','{fip.BTYPE}','{fip.BPRICE}')");

            //Message
            MessageBox.Show("Product inserted successfully");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //this.Show();
        }

        private void btnUpdateFood_Click_1(object sender, EventArgs e)
        {

            //isnt frmUpdateProducts
            frmUpdateProducts fu = new frmUpdateProducts();
            fu.ShowDialog();


            //Update operations food
            UpdateProduct("UPDATE Food SET FoodPrice = '" + fu.updateFoodPice + "' WHERE FoodName = '" + fu.FNAME + "'");

            //Message
            MessageBox.Show("Product updated successfully");

            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //focussing on the insert bev control
            btnInserBev.Focus();
        }

        private void btnUpdateBeverage_Click(object sender, EventArgs e)
        {
            //isnt frmUpdateProducts
            frmUpdateProducts fu = new frmUpdateProducts();
            fu.ShowDialog();

            //Update operations food
            UpdateProduct($"UPDATE Drinks SET BeveragePrice = '{fu.updateBevPrice}' WHERE BerageName = '{fu.DNAME}'");

            //Message
            MessageBox.Show("Product updated successfully");

            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //focussing on the insert bev control
            btnInserBev.Focus();
        }

        private void btnDeleteFood_Click_1(object sender, EventArgs e)
        {
            //if nothing is selected 
            if (lstStaffReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product that you want to delete from the list box");
            }



            int comPos = lstStaffReport.SelectedItem.ToString().IndexOf(",");
            string FDName = lstStaffReport.SelectedItem.ToString().Substring(0, (comPos));

            //Delete operations
            DeleteProduct("DELETE FROM Food WHERE FoodName = '" + FDName + "'");

      


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //enabling the relevant buttons
            //btnDeleteBev.Enabled = true;
            //btnDeleteFood.Enabled = true;
            btnUpdateBeverage.Enabled = true;
            btnUpdateFood.Enabled = true;
            btnInserBev.Enabled = true;
            btnInsertFood.Enabled = true;

            //focussing on the insert bev control
            btnInserBev.Focus();

            //disabling the relevant controls
            btnDeleteBev.Enabled = false;
            btnDeleteFood.Enabled = false;
        }

        private void btnDeleteBev_Click(object sender, EventArgs e)
        {
            //inst frmInsertProduct
            //frmInsertProduct fip = new frmInsertProduct();

            MessageBox.Show("Before" + lstStaffReport.Items.Count);

            

            //if nothing is selected 
            if (lstStaffReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product that you want to delete from the list box");
            }
            


            int comPos = lstStaffReport.SelectedItem.ToString().IndexOf(",");
            string BevName = lstStaffReport.SelectedItem.ToString().Substring(0, (comPos));

            MessageBox.Show("Selected product is _" + BevName + "_");

            //Delete operations
            DeleteProduct("DELETE FROM Drinks WHERE BerageName = '" + BevName + "'");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("-");
            lstStaffReport.Items.Add("\n");
            lstStaffReport.Items.Add("_");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");


            //enabling the relevant buttons
            //btnDeleteBev.Enabled = true;
            //btnDeleteFood.Enabled = true;
            btnUpdateBeverage.Enabled = true;
            btnUpdateFood.Enabled = true;
            btnInserBev.Enabled = true;
            btnInsertFood.Enabled = true;

            //focussing on the insert bev control
            btnInserBev.Focus();

            //disabling the relevant controls
            btnDeleteBev.Enabled = false;
            btnDeleteFood.Enabled = false;


            MessageBox.Show("after" + lstStaffReport.Items.Count);













            /*
            //if nothing is selected 
            if (lstStaffReport.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product that you want to delete from the list box");
            }



            int comPos = lstStaffReport.SelectedItem.ToString().IndexOf(",");
            string FDName = lstStaffReport.SelectedItem.ToString().Substring(0, (comPos));

            //Delete operations
            DeleteProduct("DELETE FROM Food WHERE FoodName = '" + FDName + "'");


            //clearing the listbox
            lstStaffReport.Items.Clear();


            //Display all products that are provided
            //Heading
            lstStaffReport.Items.Add("Beverages");
            //list of beverages
            ReadDRINKS("SELECT * FROM Drinks");

            //making space
            lstStaffReport.Items.Add("\n");

            //Heading
            lstStaffReport.Items.Add("Food");
            //list of beverages
            ReadFOOD("SELECT * FROM Food");

            //enabling the relevant buttons
            btnDeleteBev.Enabled = true;
            btnDeleteFood.Enabled = true;
            btnUpdateBeverage.Enabled = true;
            btnUpdateFood.Enabled = true;
            btnInserBev.Enabled = true;
            btnInsertFood.Enabled = true;

            //focussing on the insert bev control
            btnInserBev.Focus();

            //disabling the relevant controls
            btnDeleteBev.Enabled = false;
            btnDeleteFood.Enabled = false;*/
        }

        private void lstStaffReport_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if a drink is selected
            int uPos =0;
            uPos = lstStaffReport.Items.IndexOf("_");

            int dPos = 0;
            dPos = lstStaffReport.Items.IndexOf("-");




           // MessageBox.Show("uPos: " + uPos);

            if(lstStaffReport.SelectedIndex < 1)
            {
                btnDeleteBev.Enabled = false;
            }


            //enabling and disabling the relevent controls
            if (lstStaffReport.SelectedIndex <= uPos && lstStaffReport.SelectedIndex >= dPos)
            {
                btnDeleteBev.Enabled = false;
                btnDeleteFood.Enabled = false;
            }
            else if (lstStaffReport.SelectedIndex > 0 && lstStaffReport.SelectedIndex < (dPos))
            {
                btnDeleteBev.Enabled = true;
                btnDeleteFood.Enabled = false;
                btnUpdateBeverage.Enabled = false;
                btnUpdateFood.Enabled = false;
                btnInserBev.Enabled = false;
                btnInsertFood.Enabled = false;
            }
            else if (lstStaffReport.SelectedIndex > (uPos + 1))
            {
                btnDeleteFood.Enabled = true;
                btnDeleteBev.Enabled = false;
            }/*
            else
            {
                btnDeleteBev.Enabled = false;
                btnDeleteFood.Enabled = false;
                btnUpdateBeverage.Enabled = true;
                btnUpdateFood.Enabled = true;
                btnInserBev.Enabled = true;
                btnInsertFood.Enabled = true;
            }*/

            

            

        }

        private void lstStaffReport_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            //Closing the application
            Application.Exit();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //Displaying the report of the order that has been made
            OrderReport("SELECT * FROM AddToCart");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {

        }

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
                lstProductList.Items.Add("Beverage details");
                //lstProductList.Items.Add("ID: " + "\t" + "Name: " + "\t" + "\t" + "Size: " + "\t" + "Type: " + "\t" + "Price: R");
                while (dreader.Read())
                {
                    //lstProductList.Items.Add("ID: " + dreader.GetValue(0) + "\t" + "Name: " + dreader.GetValue(1) + "\t" + "Size: " + dreader.GetValue(2) + "\t" + "Type: " + dreader.GetValue(3) + "\t" + "Price: R" + dreader.GetValue(4));
                    lstProductList.Items.Add(("ID: " + dreader.GetValue(0) + "\t" + "Name: " + dreader.GetValue(1) + "\t" + "Size: " + dreader.GetValue(2) + "\t" + "Type: " + dreader.GetValue(3) + "\t" + "Price: R" + dreader.GetValue(4)));
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
                lstProductList.Items.Add("Food details");
                while (dreader.Read())
                {
                    lstProductList.Items.Add(("ID: " + dreader.GetValue(0) + "\t" + "Name: " + dreader.GetValue(1) + "\t" + "Type: " + dreader.GetValue(2) + "\t" + "Price: R" + dreader.GetValue(3)));
                }
                //Closing the connection 
                con.Close();
            }//catching thrown exceptions
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                //clearing the list box
                lstProductList.Items.Clear();


                //Displaying a list of steaming beverages
                ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Steaming beverage'");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //clearing the list box
                lstProductList.Items.Clear();

                //Displaying a list of chilled beverages
                ReadDrinks("SELECT * FROM Drinks WHERE BeverageType = 'Chilled Beverage'");
            }
               

           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                //clearing the list box
                lstProductList.Items.Clear();

                //Displaying a list of sandwiches
                ReadFood("SELECT * FROM Food WHERE FoodType = 'Sandwich'");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                //clearing the list box
                lstProductList.Items.Clear();

                //Displaying a list of sandwiches
                ReadFood("SELECT * FROM Food WHERE FoodType = 'Baked treat'");
            }
        }
    }
}
