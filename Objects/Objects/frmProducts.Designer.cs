namespace Objects
{
    partial class frmProducts
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
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOnHand = new System.Windows.Forms.TextBox();
            this.txtUnitOfMeasure = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblUnitOfMeasure = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.txtPurchPrice = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.txtOverhead = new System.Windows.Forms.TextBox();
            this.txtMfgCost = new System.Windows.Forms.TextBox();
            this.lblVendorId = new System.Windows.Forms.Label();
            this.lblPurchPrice = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblOverhead = new System.Windows.Forms.Label();
            this.lblMfgCost = new System.Windows.Forms.Label();
            this.lblStdCost = new System.Windows.Forms.Label();
            this.lblCostOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(135, 64);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProductNumber.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 119);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtOnHand
            // 
            this.txtOnHand.Location = new System.Drawing.Point(135, 174);
            this.txtOnHand.Name = "txtOnHand";
            this.txtOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtOnHand.TabIndex = 2;
            // 
            // txtUnitOfMeasure
            // 
            this.txtUnitOfMeasure.Location = new System.Drawing.Point(135, 229);
            this.txtUnitOfMeasure.Name = "txtUnitOfMeasure";
            this.txtUnitOfMeasure.Size = new System.Drawing.Size(100, 20);
            this.txtUnitOfMeasure.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(109, 307);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(61, 40);
            this.btnLookUp.TabIndex = 11;
            this.btnLookUp.Text = "Look Up";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(199, 307);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(61, 40);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Inventory Control";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(23, 64);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(84, 13);
            this.lblProductNumber.TabIndex = 14;
            this.lblProductNumber.Text = "Product Number";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(47, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Location = new System.Drawing.Point(57, 174);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(50, 13);
            this.lblOnHand.TabIndex = 16;
            this.lblOnHand.Text = "On Hand";
            // 
            // lblUnitOfMeasure
            // 
            this.lblUnitOfMeasure.AutoSize = true;
            this.lblUnitOfMeasure.Location = new System.Drawing.Point(25, 229);
            this.lblUnitOfMeasure.Name = "lblUnitOfMeasure";
            this.lblUnitOfMeasure.Size = new System.Drawing.Size(82, 13);
            this.lblUnitOfMeasure.TabIndex = 17;
            this.lblUnitOfMeasure.Text = "Unit of Measure";
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(409, 37);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(100, 20);
            this.txtVendorId.TabIndex = 4;
            // 
            // txtPurchPrice
            // 
            this.txtPurchPrice.Location = new System.Drawing.Point(409, 87);
            this.txtPurchPrice.Name = "txtPurchPrice";
            this.txtPurchPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchPrice.TabIndex = 5;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(409, 137);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 6;
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(409, 187);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(100, 20);
            this.txtShipping.TabIndex = 7;
            // 
            // txtOverhead
            // 
            this.txtOverhead.Location = new System.Drawing.Point(409, 237);
            this.txtOverhead.Name = "txtOverhead";
            this.txtOverhead.Size = new System.Drawing.Size(100, 20);
            this.txtOverhead.TabIndex = 8;
            // 
            // txtMfgCost
            // 
            this.txtMfgCost.Location = new System.Drawing.Point(409, 287);
            this.txtMfgCost.Name = "txtMfgCost";
            this.txtMfgCost.Size = new System.Drawing.Size(100, 20);
            this.txtMfgCost.TabIndex = 9;
            // 
            // lblVendorId
            // 
            this.lblVendorId.AutoSize = true;
            this.lblVendorId.Location = new System.Drawing.Point(318, 37);
            this.lblVendorId.Name = "lblVendorId";
            this.lblVendorId.Size = new System.Drawing.Size(55, 13);
            this.lblVendorId.TabIndex = 18;
            this.lblVendorId.Text = "Vendor ID";
            // 
            // lblPurchPrice
            // 
            this.lblPurchPrice.AutoSize = true;
            this.lblPurchPrice.Location = new System.Drawing.Point(308, 87);
            this.lblPurchPrice.Name = "lblPurchPrice";
            this.lblPurchPrice.Size = new System.Drawing.Size(65, 13);
            this.lblPurchPrice.TabIndex = 19;
            this.lblPurchPrice.Text = "Purch. Price";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(322, 137);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(51, 13);
            this.lblTaxRate.TabIndex = 20;
            this.lblTaxRate.Text = "Tax Rate";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(325, 187);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(48, 13);
            this.lblShipping.TabIndex = 21;
            this.lblShipping.Text = "Shipping";
            // 
            // lblOverhead
            // 
            this.lblOverhead.AutoSize = true;
            this.lblOverhead.Location = new System.Drawing.Point(308, 237);
            this.lblOverhead.Name = "lblOverhead";
            this.lblOverhead.Size = new System.Drawing.Size(65, 13);
            this.lblOverhead.TabIndex = 22;
            this.lblOverhead.Text = "Overhead %";
            // 
            // lblMfgCost
            // 
            this.lblMfgCost.AutoSize = true;
            this.lblMfgCost.Location = new System.Drawing.Point(319, 287);
            this.lblMfgCost.Name = "lblMfgCost";
            this.lblMfgCost.Size = new System.Drawing.Size(54, 13);
            this.lblMfgCost.TabIndex = 23;
            this.lblMfgCost.Text = "MFG Cost";
            // 
            // lblStdCost
            // 
            this.lblStdCost.AutoSize = true;
            this.lblStdCost.Location = new System.Drawing.Point(57, 268);
            this.lblStdCost.Name = "lblStdCost";
            this.lblStdCost.Size = new System.Drawing.Size(50, 13);
            this.lblStdCost.TabIndex = 24;
            this.lblStdCost.Text = "Std. Cost";
            // 
            // lblCostOut
            // 
            this.lblCostOut.AutoSize = true;
            this.lblCostOut.Location = new System.Drawing.Point(135, 268);
            this.lblCostOut.Name = "lblCostOut";
            this.lblCostOut.Size = new System.Drawing.Size(46, 13);
            this.lblCostOut.TabIndex = 25;
            this.lblCostOut.Text = "$100.00";
            this.lblCostOut.Visible = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 359);
            this.Controls.Add(this.lblCostOut);
            this.Controls.Add(this.lblStdCost);
            this.Controls.Add(this.lblMfgCost);
            this.Controls.Add(this.lblOverhead);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblPurchPrice);
            this.Controls.Add(this.lblVendorId);
            this.Controls.Add(this.txtMfgCost);
            this.Controls.Add(this.txtOverhead);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.txtPurchPrice);
            this.Controls.Add(this.txtVendorId);
            this.Controls.Add(this.lblUnitOfMeasure);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUnitOfMeasure);
            this.Controls.Add(this.txtOnHand);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProductNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmProducts";
            this.Text = "Product Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOnHand;
        private System.Windows.Forms.TextBox txtUnitOfMeasure;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label lblUnitOfMeasure;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.TextBox txtPurchPrice;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.TextBox txtOverhead;
        private System.Windows.Forms.TextBox txtMfgCost;
        private System.Windows.Forms.Label lblVendorId;
        private System.Windows.Forms.Label lblPurchPrice;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblOverhead;
        private System.Windows.Forms.Label lblMfgCost;
        private System.Windows.Forms.Label lblStdCost;
        private System.Windows.Forms.Label lblCostOut;
    }
}

