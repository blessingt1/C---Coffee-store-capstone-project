
namespace _41136063_Assignment1
{
    partial class frmStaff
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblYourOrder = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnInsertFood = new System.Windows.Forms.Button();
            this.lblProductManagement = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDeleteBev = new System.Windows.Forms.Button();
            this.btnUpdateBeverage = new System.Windows.Forms.Button();
            this.btnInserBev = new System.Windows.Forms.Button();
            this.lstStaffReport = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage3.Controls.Add(this.lstProductList);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge1;
            this.tabPage2.Controls.Add(this.lblYourOrder);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders received";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // lblYourOrder
            // 
            this.lblYourOrder.AutoSize = true;
            this.lblYourOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblYourOrder.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrder.Location = new System.Drawing.Point(6, 39);
            this.lblYourOrder.Name = "lblYourOrder";
            this.lblYourOrder.Size = new System.Drawing.Size(215, 34);
            this.lblYourOrder.TabIndex = 6;
            this.lblYourOrder.Text = "Orders received";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUpdateFood);
            this.tabPage1.Controls.Add(this.btnDeleteFood);
            this.tabPage1.Controls.Add(this.btnInsertFood);
            this.tabPage1.Controls.Add(this.lblProductManagement);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Controls.Add(this.btnDeleteBev);
            this.tabPage1.Controls.Add(this.btnUpdateBeverage);
            this.tabPage1.Controls.Add(this.btnInserBev);
            this.tabPage1.Controls.Add(this.lstStaffReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product management";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "on the one of the delete buttons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "on the list box above, then click ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "To delete, select the item on";
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(311, 508);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(107, 36);
            this.btnUpdateFood.TabIndex = 22;
            this.btnUpdateFood.Text = "Update Food";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click_1);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(457, 508);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(107, 36);
            this.btnDeleteFood.TabIndex = 21;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click_1);
            // 
            // btnInsertFood
            // 
            this.btnInsertFood.Location = new System.Drawing.Point(169, 508);
            this.btnInsertFood.Name = "btnInsertFood";
            this.btnInsertFood.Size = new System.Drawing.Size(107, 36);
            this.btnInsertFood.TabIndex = 20;
            this.btnInsertFood.Text = "Insert Food";
            this.btnInsertFood.UseVisualStyleBackColor = true;
            this.btnInsertFood.Click += new System.EventHandler(this.btnInsertFood_Click_1);
            // 
            // lblProductManagement
            // 
            this.lblProductManagement.AutoSize = true;
            this.lblProductManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblProductManagement.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductManagement.Location = new System.Drawing.Point(32, 72);
            this.lblProductManagement.Name = "lblProductManagement";
            this.lblProductManagement.Size = new System.Drawing.Size(309, 35);
            this.lblProductManagement.TabIndex = 19;
            this.lblProductManagement.Text = "Product Management";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(32, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(141, 35);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnDeleteBev
            // 
            this.btnDeleteBev.Location = new System.Drawing.Point(456, 454);
            this.btnDeleteBev.Name = "btnDeleteBev";
            this.btnDeleteBev.Size = new System.Drawing.Size(107, 36);
            this.btnDeleteBev.TabIndex = 17;
            this.btnDeleteBev.Text = "Delete Beverage";
            this.btnDeleteBev.UseVisualStyleBackColor = true;
            this.btnDeleteBev.Click += new System.EventHandler(this.btnDeleteBev_Click);
            // 
            // btnUpdateBeverage
            // 
            this.btnUpdateBeverage.Location = new System.Drawing.Point(311, 453);
            this.btnUpdateBeverage.Name = "btnUpdateBeverage";
            this.btnUpdateBeverage.Size = new System.Drawing.Size(107, 36);
            this.btnUpdateBeverage.TabIndex = 16;
            this.btnUpdateBeverage.Text = "Update Beverage";
            this.btnUpdateBeverage.UseVisualStyleBackColor = true;
            this.btnUpdateBeverage.Click += new System.EventHandler(this.btnUpdateBeverage_Click);
            // 
            // btnInserBev
            // 
            this.btnInserBev.Location = new System.Drawing.Point(169, 454);
            this.btnInserBev.Name = "btnInserBev";
            this.btnInserBev.Size = new System.Drawing.Size(107, 36);
            this.btnInserBev.TabIndex = 15;
            this.btnInserBev.Text = "Insert Beverage";
            this.btnInserBev.UseVisualStyleBackColor = true;
            this.btnInserBev.Click += new System.EventHandler(this.btnInserBev_Click);
            // 
            // lstStaffReport
            // 
            this.lstStaffReport.FormattingEnabled = true;
            this.lstStaffReport.Location = new System.Drawing.Point(38, 139);
            this.lstStaffReport.Name = "lstStaffReport";
            this.lstStaffReport.Size = new System.Drawing.Size(655, 277);
            this.lstStaffReport.TabIndex = 14;
            this.lstStaffReport.SelectedIndexChanged += new System.EventHandler(this.lstStaffReport_SelectedIndexChanged);
            this.lstStaffReport.Enter += new System.EventHandler(this.lstStaffReport_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 560);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Exit";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Report of products";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(622, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product types";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Steaming beverages";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chilled beverages";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sandwich";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Baked treats";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lstProductList
            // 
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.Location = new System.Drawing.Point(0, 100);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(616, 238);
            this.lstProductList.TabIndex = 9;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnInsertFood;
        private System.Windows.Forms.Label lblProductManagement;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDeleteBev;
        private System.Windows.Forms.Button btnUpdateBeverage;
        private System.Windows.Forms.Button btnInserBev;
        private System.Windows.Forms.ListBox lstStaffReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblYourOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lstProductList;
    }
}