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
    public partial class frmInsertProduct : Form
    {
        public frmInsertProduct()
        {
            InitializeComponent();
        }

        private void frmInsertProduct_Load(object sender, EventArgs e)
        {

        }

        //public variables 
        //Beverage attribute variables
        public int BID;
        public string BNAME;
        public string BSIZE;
        public string BTYPE;
        public decimal BPRICE;

        //Food attribute variables
        public int FID;
        public string FNAME;
        public string FTYPE;
        public decimal FPRICE;

        private void btnInsertBevItem_Click(object sender, EventArgs e)
        {
            //validation booleans
            bool id;
            bool name;
            bool type;
            bool price;
            bool size;


            //input validation
            if (int.TryParse(txtBID.Text, out BID))
            {
                id = true;
                errorProvider1.SetError(txtBID, "");
                //BID = int.Parse(txtBID.Text);
            }
            else
            {
                id = false;
                errorProvider1.SetError(txtBID, "Please enter a valid id");
            }


            //BNAME
            if (txtBNAME.Text == "")
            {
                name = false;
                errorProvider1.SetError(txtBNAME, "Please enter a valid name");
            }
            else
            {
                name = true;
                errorProvider1.SetError(txtBNAME, "");
                BNAME = txtBNAME.Text;
            }
            //Size
            if (txtBSIZE.Text.ToLower() != "small" && txtBSIZE.Text.ToLower() != "medium" && txtBSIZE.Text.ToLower() != "large")
            {
                size = false;
                errorProvider1.SetError(txtBSIZE, "Please enter a valid size(small/medium/large)");
            }
            else
            {
                size = true;
                errorProvider1.SetError(txtBSIZE, "");
                BSIZE = txtBSIZE.Text;
            }
            //Type
            if (txtBTYPE.Text.ToLower() == "")
            {
                type = false;
                errorProvider1.SetError(txtBTYPE, "Please enter a valid type(chilled beverage/steaming beverage");
            }
            else
            {
                type = true;
                errorProvider1.SetError(txtBTYPE, "");
                BTYPE = txtBTYPE.Text;
            }
            //price
            if (decimal.TryParse(txtBPRICE.Text, out BPRICE))
            {
                price = true;
                errorProvider1.SetError(txtBPRICE, "");
                //BPRICE = decimal.Parse(txtBPRICE.Text);
            }
            else
            {
                price = false;
                errorProvider1.SetError(txtBPRICE, "Please enter a valid price");
            }

            /*
            if (decimal.Parse(txtBPRICE.Text) > 8 || decimal.Parse(txtBPRICE.Text) < 90)
            {
                errorProvider1.SetError(txtBPRICE, "");
                //BPRICE = decimal.Parse(txtBPRICE.Text);
            }
            else
            {
                errorProvider1.SetError(txtBPRICE, "Please enter a valid price(between 8 and 90");
            }*/

            //final validation
            if(id == true && name == true && type == true && size == true && price == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please reevaluate your input and reenter your values");
            }
            
        }

        private void btnInsertFoodItem_Click(object sender, EventArgs e)
        {
            //validation booleans
            bool id;
            bool name;
            bool type;
            bool price;


            //input validation
            //Id
            if (int.TryParse(txtFID.Text, out FID))
            {
                id = true;
                errorProvider1.SetError(txtFID, "");
                FID = int.Parse(txtFID.Text);
            }
            else
            {
                id = false;
                errorProvider1.SetError(txtFID, "Please enter a valid id");
            }
            
            //Name
            if (txtFNAME.Text == "")
            {
                name = false;
                errorProvider1.SetError(txtFNAME, "Please enter a valid name");
            }
            else
            {
                name = true;
                errorProvider1.SetError(txtFNAME, "");
                FNAME = txtFNAME.Text;
            }
            //Type
            if (txtFTYPE.Text.ToLower() == "")
            {
                type = false;
                errorProvider1.SetError(txtFTYPE, "Please enter a valid type(sandwich or baked treat");
            }
            else
            {
                type = true;
                errorProvider1.SetError(txtFTYPE, "");
                FTYPE = txtFTYPE.Text;
            }
            //Price
            if (decimal.TryParse(txtFPRICE.Text, out BPRICE))
            {
                price = true;
                errorProvider1.SetError(txtFPRICE, "");
                FPRICE = decimal.Parse(txtFPRICE.Text);
            }
            else
            {
                price = false;
                errorProvider1.SetError(txtFPRICE, "Please enter a valid price");
            }
            /*
            if (decimal.Parse(txtFPRICE.Text) > 10 || decimal.Parse(txtFPRICE.Text) < 150)
            {
                errorProvider1.SetError(txtFPRICE, "");
                //BPRICE = decimal.Parse(txtBPRICE.Text);
            }
            else
            {
                errorProvider1.SetError(txtFPRICE, "Please enter a valid price(between 10 and 150");
            }*/

            //final validation
            if (id == true && name == true && type == true && price == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please reevaluate your input and reenter your values");
            }
        }
    }
}
