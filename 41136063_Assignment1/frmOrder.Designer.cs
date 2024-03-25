
namespace _41136063_Assignment1
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBakedTreats = new System.Windows.Forms.Label();
            this.lblSandwich = new System.Windows.Forms.Label();
            this.lblChilledBeverages = new System.Windows.Forms.Label();
            this.lblSteamingBeverages = new System.Windows.Forms.Label();
            this.pbBakedTreats = new System.Windows.Forms.PictureBox();
            this.pbSandwhich = new System.Windows.Forms.PictureBox();
            this.pbChilledBeverages = new System.Windows.Forms.PictureBox();
            this.pbSteamingBeverages = new System.Windows.Forms.PictureBox();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.btnGoToCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.lstCartReport = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYourOrder = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakedTreats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSandwhich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChilledBeverages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteamingBeverages)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 586);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage1.Controls.Add(this.lblBakedTreats);
            this.tabPage1.Controls.Add(this.lblSandwich);
            this.tabPage1.Controls.Add(this.lblChilledBeverages);
            this.tabPage1.Controls.Add(this.lblSteamingBeverages);
            this.tabPage1.Controls.Add(this.pbBakedTreats);
            this.tabPage1.Controls.Add(this.pbSandwhich);
            this.tabPage1.Controls.Add(this.pbChilledBeverages);
            this.tabPage1.Controls.Add(this.pbSteamingBeverages);
            this.tabPage1.Controls.Add(this.lstProductList);
            this.tabPage1.Controls.Add(this.btnGoToCart);
            this.tabPage1.Controls.Add(this.btnAddToCart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // lblBakedTreats
            // 
            this.lblBakedTreats.AutoSize = true;
            this.lblBakedTreats.BackColor = System.Drawing.Color.BurlyWood;
            this.lblBakedTreats.Location = new System.Drawing.Point(269, 469);
            this.lblBakedTreats.Name = "lblBakedTreats";
            this.lblBakedTreats.Size = new System.Drawing.Size(71, 13);
            this.lblBakedTreats.TabIndex = 21;
            this.lblBakedTreats.Text = "Baked Treats";
            // 
            // lblSandwich
            // 
            this.lblSandwich.AutoSize = true;
            this.lblSandwich.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSandwich.Location = new System.Drawing.Point(3, 469);
            this.lblSandwich.Name = "lblSandwich";
            this.lblSandwich.Size = new System.Drawing.Size(54, 13);
            this.lblSandwich.TabIndex = 20;
            this.lblSandwich.Text = "Sandwich";
            // 
            // lblChilledBeverages
            // 
            this.lblChilledBeverages.AutoSize = true;
            this.lblChilledBeverages.BackColor = System.Drawing.Color.BurlyWood;
            this.lblChilledBeverages.Location = new System.Drawing.Point(269, 79);
            this.lblChilledBeverages.Name = "lblChilledBeverages";
            this.lblChilledBeverages.Size = new System.Drawing.Size(92, 13);
            this.lblChilledBeverages.TabIndex = 19;
            this.lblChilledBeverages.Text = "Chilled Beverages";
            // 
            // lblSteamingBeverages
            // 
            this.lblSteamingBeverages.AutoSize = true;
            this.lblSteamingBeverages.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSteamingBeverages.Location = new System.Drawing.Point(6, 79);
            this.lblSteamingBeverages.Name = "lblSteamingBeverages";
            this.lblSteamingBeverages.Size = new System.Drawing.Size(105, 13);
            this.lblSteamingBeverages.TabIndex = 18;
            this.lblSteamingBeverages.Text = "Steaming Beverages";
            // 
            // pbBakedTreats
            // 
            this.pbBakedTreats.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.D;
            this.pbBakedTreats.Location = new System.Drawing.Point(272, 300);
            this.pbBakedTreats.Name = "pbBakedTreats";
            this.pbBakedTreats.Size = new System.Drawing.Size(172, 144);
            this.pbBakedTreats.TabIndex = 17;
            this.pbBakedTreats.TabStop = false;
            this.pbBakedTreats.Click += new System.EventHandler(this.pbBakedTreats_Click_1);
            // 
            // pbSandwhich
            // 
            this.pbSandwhich.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.sandwich_4k_for_desktop_wallpaper_preview;
            this.pbSandwhich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSandwhich.Location = new System.Drawing.Point(6, 300);
            this.pbSandwhich.Name = "pbSandwhich";
            this.pbSandwhich.Size = new System.Drawing.Size(172, 144);
            this.pbSandwhich.TabIndex = 16;
            this.pbSandwhich.TabStop = false;
            this.pbSandwhich.Click += new System.EventHandler(this.pbSandwhich_Click_1);
            // 
            // pbChilledBeverages
            // 
            this.pbChilledBeverages.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.ice_cold_refreshment_cool;
            this.pbChilledBeverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChilledBeverages.Location = new System.Drawing.Point(272, 120);
            this.pbChilledBeverages.Name = "pbChilledBeverages";
            this.pbChilledBeverages.Size = new System.Drawing.Size(172, 144);
            this.pbChilledBeverages.TabIndex = 15;
            this.pbChilledBeverages.TabStop = false;
            this.pbChilledBeverages.Click += new System.EventHandler(this.pbChilledBeverages_Click_1);
            // 
            // pbSteamingBeverages
            // 
            this.pbSteamingBeverages.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.Steaming_beverage;
            this.pbSteamingBeverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSteamingBeverages.Location = new System.Drawing.Point(6, 120);
            this.pbSteamingBeverages.Name = "pbSteamingBeverages";
            this.pbSteamingBeverages.Size = new System.Drawing.Size(172, 144);
            this.pbSteamingBeverages.TabIndex = 14;
            this.pbSteamingBeverages.TabStop = false;
            this.pbSteamingBeverages.Click += new System.EventHandler(this.pbSteamingBeverages_Click_1);
            // 
            // lstProductList
            // 
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.Location = new System.Drawing.Point(526, 120);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(233, 134);
            this.lstProductList.TabIndex = 13;
            this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged_1);
            // 
            // btnGoToCart
            // 
            this.btnGoToCart.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGoToCart.Location = new System.Drawing.Point(526, 407);
            this.btnGoToCart.Name = "btnGoToCart";
            this.btnGoToCart.Size = new System.Drawing.Size(106, 37);
            this.btnGoToCart.TabIndex = 12;
            this.btnGoToCart.Text = "Go to cart";
            this.btnGoToCart.UseVisualStyleBackColor = false;
            this.btnGoToCart.Click += new System.EventHandler(this.btnGoToCart_Click_1);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAddToCart.Location = new System.Drawing.Point(526, 353);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(106, 37);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage2.Controls.Add(this.lblEmpty);
            this.tabPage2.Controls.Add(this.lblRemoveItem);
            this.tabPage2.Controls.Add(this.btnRemoveItems);
            this.tabPage2.Controls.Add(this.btnAddItems);
            this.tabPage2.Controls.Add(this.btnProceedToPayment);
            this.tabPage2.Controls.Add(this.lstCartReport);
            this.tabPage2.Controls.Add(this.lblCart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cart";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(116, 61);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(0, 31);
            this.lblEmpty.TabIndex = 13;
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveItem.Location = new System.Drawing.Point(328, 486);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(430, 13);
            this.lblRemoveItem.TabIndex = 12;
            this.lblRemoveItem.Text = "Click on the item you would like to remove(on the listbox above then click on rem" +
    "ove item.";
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.BurlyWood;
            this.btnRemoveItems.Location = new System.Drawing.Point(331, 435);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(135, 48);
            this.btnRemoveItems.TabIndex = 11;
            this.btnRemoveItems.Text = "Remove item";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAddItems.Location = new System.Drawing.Point(169, 435);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(135, 48);
            this.btnAddItems.TabIndex = 10;
            this.btnAddItems.Text = "Add item";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.BurlyWood;
            this.btnProceedToPayment.Location = new System.Drawing.Point(10, 435);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(135, 48);
            this.btnProceedToPayment.TabIndex = 9;
            this.btnProceedToPayment.Text = "Proceed to payment";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // lstCartReport
            // 
            this.lstCartReport.FormattingEnabled = true;
            this.lstCartReport.Location = new System.Drawing.Point(10, 108);
            this.lstCartReport.Name = "lstCartReport";
            this.lstCartReport.Size = new System.Drawing.Size(648, 303);
            this.lstCartReport.TabIndex = 8;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(4, 61);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(71, 34);
            this.lblCart.TabIndex = 7;
            this.lblCart.Text = "Cart";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage3.Controls.Add(this.btnDone);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lblYourOrder);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payment";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage3_DragEnter);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " In the meanwhile, please make sure that you have your cash or your card ready fo" +
    "r payment.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your order is being prepared and will be provided within the next 20 minues.";
            // 
            // lblYourOrder
            // 
            this.lblYourOrder.AutoSize = true;
            this.lblYourOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblYourOrder.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrder.Location = new System.Drawing.Point(22, 37);
            this.lblYourOrder.Name = "lblYourOrder";
            this.lblYourOrder.Size = new System.Drawing.Size(173, 34);
            this.lblYourOrder.TabIndex = 5;
            this.lblYourOrder.Text = "Your Order:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 248);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(28, 408);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakedTreats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSandwhich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChilledBeverages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteamingBeverages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblBakedTreats;
        private System.Windows.Forms.Label lblSandwich;
        private System.Windows.Forms.Label lblChilledBeverages;
        private System.Windows.Forms.Label lblSteamingBeverages;
        private System.Windows.Forms.PictureBox pbBakedTreats;
        private System.Windows.Forms.PictureBox pbSandwhich;
        private System.Windows.Forms.PictureBox pbChilledBeverages;
        private System.Windows.Forms.PictureBox pbSteamingBeverages;
        private System.Windows.Forms.ListBox lstProductList;
        private System.Windows.Forms.Button btnGoToCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblRemoveItem;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnProceedToPayment;
        private System.Windows.Forms.ListBox lstCartReport;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYourOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDone;
    }
}