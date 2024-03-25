
namespace _41136063_Assignment1
{
    partial class frmUpdateProducts
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdateFPRICE = new System.Windows.Forms.Button();
            this.btnUPDATED = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFUp = new System.Windows.Forms.TextBox();
            this.lblNewFPrice = new System.Windows.Forms.Label();
            this.txtBUp = new System.Windows.Forms.TextBox();
            this.lblNewBPRICE = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lstUpdateList = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateFPRICE
            // 
            this.btnUpdateFPRICE.Location = new System.Drawing.Point(551, 467);
            this.btnUpdateFPRICE.Name = "btnUpdateFPRICE";
            this.btnUpdateFPRICE.Size = new System.Drawing.Size(143, 38);
            this.btnUpdateFPRICE.TabIndex = 35;
            this.btnUpdateFPRICE.Text = "Update Food Price";
            this.btnUpdateFPRICE.UseVisualStyleBackColor = true;
            this.btnUpdateFPRICE.Click += new System.EventHandler(this.btnUpdateFPRICE_Click);
            // 
            // btnUPDATED
            // 
            this.btnUPDATED.Location = new System.Drawing.Point(184, 467);
            this.btnUPDATED.Name = "btnUPDATED";
            this.btnUPDATED.Size = new System.Drawing.Size(143, 38);
            this.btnUPDATED.TabIndex = 34;
            this.btnUPDATED.Text = "Update Beverage Price";
            this.btnUPDATED.UseVisualStyleBackColor = true;
            this.btnUPDATED.Click += new System.EventHandler(this.btnUPDATED_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Price Update";
            // 
            // txtFUp
            // 
            this.txtFUp.Location = new System.Drawing.Point(551, 411);
            this.txtFUp.Name = "txtFUp";
            this.txtFUp.Size = new System.Drawing.Size(143, 20);
            this.txtFUp.TabIndex = 32;
            // 
            // lblNewFPrice
            // 
            this.lblNewFPrice.AutoSize = true;
            this.lblNewFPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblNewFPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewFPrice.Location = new System.Drawing.Point(447, 414);
            this.lblNewFPrice.Name = "lblNewFPrice";
            this.lblNewFPrice.Size = new System.Drawing.Size(79, 13);
            this.lblNewFPrice.TabIndex = 31;
            this.lblNewFPrice.Text = "New food price";
            // 
            // txtBUp
            // 
            this.txtBUp.Location = new System.Drawing.Point(184, 411);
            this.txtBUp.Name = "txtBUp";
            this.txtBUp.Size = new System.Drawing.Size(143, 20);
            this.txtBUp.TabIndex = 30;
            // 
            // lblNewBPRICE
            // 
            this.lblNewBPRICE.AutoSize = true;
            this.lblNewBPRICE.BackColor = System.Drawing.Color.Transparent;
            this.lblNewBPRICE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewBPRICE.Location = new System.Drawing.Point(75, 414);
            this.lblNewBPRICE.Name = "lblNewBPRICE";
            this.lblNewBPRICE.Size = new System.Drawing.Size(103, 13);
            this.lblNewBPRICE.TabIndex = 29;
            this.lblNewBPRICE.Text = "New beverage price";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFood.Location = new System.Drawing.Point(446, 334);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(67, 29);
            this.lblFood.TabIndex = 28;
            this.lblFood.Text = "Food";
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.BackColor = System.Drawing.Color.Transparent;
            this.lblBeverage.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBeverage.Location = new System.Drawing.Point(77, 334);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(113, 29);
            this.lblBeverage.TabIndex = 27;
            this.lblBeverage.Text = "Beverage";
            // 
            // lstUpdateList
            // 
            this.lstUpdateList.FormattingEnabled = true;
            this.lstUpdateList.Location = new System.Drawing.Point(24, 108);
            this.lstUpdateList.Name = "lstUpdateList";
            this.lstUpdateList.Size = new System.Drawing.Size(759, 186);
            this.lstUpdateList.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_41136063_Assignment1.Properties.Resources.beigge;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.btnUpdateFPRICE);
            this.Controls.Add(this.btnUPDATED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFUp);
            this.Controls.Add(this.lblNewFPrice);
            this.Controls.Add(this.txtBUp);
            this.Controls.Add(this.lblNewBPRICE);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblBeverage);
            this.Controls.Add(this.lstUpdateList);
            this.Name = "frmUpdateProducts";
            this.Text = "frmUpdateProducts";
            this.Load += new System.EventHandler(this.frmUpdateProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateFPRICE;
        private System.Windows.Forms.Button btnUPDATED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFUp;
        private System.Windows.Forms.Label lblNewFPrice;
        private System.Windows.Forms.TextBox txtBUp;
        private System.Windows.Forms.Label lblNewBPRICE;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblBeverage;
        public System.Windows.Forms.ListBox lstUpdateList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}