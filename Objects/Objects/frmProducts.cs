/* 
 * Name: Alexander D. Martinez
 * Date: 10/27/09
 * Purpose: learn about inheretance
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Objects
{
    public partial class frmProducts : Form
    {
        //private Product myProduct = null;
        private PurchasedProduct myPurchasedProduct = null;
        private MfgProduct myMfgProduct = null;

        public frmProducts()
        {
            InitializeComponent();
        }


        //add button event handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int productNmbr = 0;
            int testProdNum = 1;
            string descrip = "";
            double onHandQ = 0;
            string uOfM = "";
            int vendIdent;
            double purPri;
            double tax;
            double shipRat;
            double ovrHed;
            double mfgCost;

            if (productNmbr != testProdNum && txtProductNumber.Text != "")
            {

                //purchased product
                if (txtVendorId.Text != "" && txtPurchPrice.Text != "" && txtTaxRate.Text != "" && txtShipping.Text != "")
                {
                    if (int.TryParse(txtProductNumber.Text, out productNmbr))
                    {

                        testProdNum = productNmbr;

                        descrip = txtDescription.Text;

                        double.TryParse(txtOnHand.Text, out onHandQ);

                        uOfM = txtUnitOfMeasure.Text;

                        int.TryParse(txtVendorId.Text, out vendIdent);
                        double.TryParse(txtPurchPrice.Text, out purPri);
                        double.TryParse(txtTaxRate.Text, out tax);
                        double.TryParse(txtShipping.Text, out shipRat);

                        myPurchasedProduct = new PurchasedProduct(vendIdent, purPri, tax, shipRat, productNmbr, descrip, onHandQ, uOfM);

                        lblCostOut.Text = string.Format("{0, 0:c}", myPurchasedProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        MessageBox.Show("Product " + Convert.ToString(myPurchasedProduct.ProductNumber) + " added.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Product number MUST be a number!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

                //manufactured producct
                if (txtOverhead.Text != "" && txtMfgCost.Text != "")
                {
                    if (int.TryParse(txtProductNumber.Text, out productNmbr))
                    {

                        testProdNum = productNmbr;

                        descrip = txtDescription.Text;

                        double.TryParse(txtOnHand.Text, out onHandQ);

                        uOfM = txtUnitOfMeasure.Text;

                        double.TryParse(txtMfgCost.Text, out mfgCost);
                        double.TryParse(txtOverhead.Text, out ovrHed);

                        myMfgProduct = new MfgProduct(mfgCost, ovrHed, productNmbr, descrip, onHandQ, uOfM);


                        lblCostOut.Text = string.Format("{0, 0:c}", myMfgProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        MessageBox.Show("Product " + Convert.ToString(myMfgProduct.ProductNumber) + " added.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Product number MUST be a number", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                if (productNmbr == testProdNum)
                {
                    MessageBox.Show("Product number entered already exisist!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Product number MUST be entered!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            txtDescription.Text = "";
            txtOnHand.Text = "";
            txtProductNumber.Text = "";
            txtUnitOfMeasure.Text = "";
            txtVendorId.Text = "";
            txtPurchPrice.Text = "";
            txtTaxRate.Text = "";
            txtShipping.Text = "";
            txtOverhead.Text = "";
            txtMfgCost.Text = "";
            lblCostOut.Visible = false;


        }//end add event handler



        //lookup even handler
        private void btnLookUp_Click(object sender, EventArgs e)
        {
            int i;
            if (txtProductNumber.Text == "")
            {
                MessageBox.Show("Product number MUST be entered!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(txtProductNumber.Text, out i))
                {
                    if (i == myPurchasedProduct.ProductNumber)
                    {
                        txtProductNumber.Text = string.Format("{0}", myPurchasedProduct.ProductNumber);
                        txtDescription.Text = myPurchasedProduct.Description;
                        txtOnHand.Text = string.Format("{0}", myPurchasedProduct.OnHandQuantity);
                        txtUnitOfMeasure.Text = myPurchasedProduct.UnitOfMeasure;
                        txtVendorId.Text = string.Format("{0}", myPurchasedProduct.VendorId);
                        txtPurchPrice.Text = string.Format("{0, 0:c}", myPurchasedProduct.PurchasePrice);
                        txtTaxRate.Text = string.Format("{0, 0:0%}", myPurchasedProduct.TaxRate);
                        txtShipping.Text = string.Format("{0, 0:c}", myPurchasedProduct.ShippingCost);
                        lblCostOut.Text = string.Format("{0, 0:c}", myPurchasedProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        txtOverhead.Text = "";
                        txtMfgCost.Text = "";

                    }
                    else if (myMfgProduct.ProductNumber != i)
                    {
                        MessageBox.Show("Product number supplied does not exist!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if(i == myMfgProduct.ProductNumber)
                    {
                        txtProductNumber.Text = string.Format("{0}", myMfgProduct.ProductNumber);
                        txtDescription.Text = myMfgProduct.Description;
                        txtOnHand.Text = string.Format("{0}", myMfgProduct.OnHandQuantity);
                        txtUnitOfMeasure.Text = myMfgProduct.UnitOfMeasure;
                        txtOverhead.Text = string.Format("{0, 0:0%}", myMfgProduct.OverHeadPercent);
                        txtMfgCost.Text = string.Format("{0, 0:c}", myMfgProduct.ManufacturedCost);
                        lblCostOut.Text = string.Format("{0, 0:c}", myMfgProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        txtVendorId.Text = "";
                        txtPurchPrice.Text = "";
                        txtTaxRate.Text = "";
                        txtShipping.Text = "";
                    }
                    else if (i != myPurchasedProduct.ProductNumber)
                    {
                        MessageBox.Show("Product number supplied does not exist!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Product number MUST be a number!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//end lookup


        //change event handler
        private void btnChange_Click(object sender, EventArgs e)
        {
            bool ynDescrip;
            bool ynOnHand;
            bool ynUnit;

            bool ynVendId;
            bool ynPurchPrice;
            bool ynTaxRate;
            bool ynShipping;

            bool ynOverHead;
            bool ynMfgCost;
            int i;
            string resultMsg = "The following properties were changed:\n";

            if (txtProductNumber.Text == "")
            {
                MessageBox.Show("Product number MUST be entered!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(txtProductNumber.Text, out i))
                {

                    //purch prod change processing
                    if (i == myPurchasedProduct.ProductNumber)
                    {
                        if (txtDescription.Text != "")
                        {
                            myPurchasedProduct.Description = txtDescription.Text;
                            ynDescrip = true;
                        }
                        else
                        {
                            ynDescrip = false;
                        }

                        if (txtOnHand.Text != "")
                        {
                            myPurchasedProduct.OnHandQuantity = Convert.ToDouble(txtOnHand.Text);
                            ynOnHand = true;
                        }
                        else
                        {
                            ynOnHand = false;
                        }

                        if (txtUnitOfMeasure.Text != "")
                        {
                            myPurchasedProduct.UnitOfMeasure = txtUnitOfMeasure.Text;
                            ynUnit = true;
                        }
                        else
                        {
                            ynUnit = false;
                        }

                        if (txtVendorId.Text != "")
                        {
                            myPurchasedProduct.VendorId = Convert.ToInt32(txtVendorId.Text);
                            ynVendId = true;
                        }
                        else
                        {
                            ynVendId = false;
                        }

                        if (txtPurchPrice.Text != "")
                        {
                            myPurchasedProduct.PurchasePrice = Convert.ToDouble(txtPurchPrice.Text);
                            ynPurchPrice = true;
                        }
                        else
                        {
                            ynPurchPrice = false;
                        }

                        if (txtTaxRate.Text != "")
                        {
                            myPurchasedProduct.TaxRate = Convert.ToDouble(txtTaxRate.Text);
                            ynTaxRate = true;
                        }
                        else
                        {
                            ynTaxRate = false;
                        }

                        if (txtShipping.Text != "")
                        {
                            myPurchasedProduct.ShippingCost = Convert.ToDouble(txtShipping.Text);
                            ynShipping = true;
                        }
                        else
                        {
                            ynShipping = false;
                        }

                        //build feedback message
                        if (ynDescrip)
                        {
                            resultMsg = resultMsg + "Description; ";
                        }

                        if (ynOnHand)
                        {
                            resultMsg = resultMsg + "On hand; ";
                        }

                        if (ynUnit)
                        { resultMsg = resultMsg + "Unit of Measure; "; }

                        if (ynVendId)
                        { resultMsg = resultMsg + "Vendor ID; "; }

                        if (ynPurchPrice)
                        { resultMsg = resultMsg + "Purch. Price; "; }

                        if (ynTaxRate)
                        { resultMsg = resultMsg + "Tax Rate; "; }

                        if (ynShipping)
                        { resultMsg = resultMsg + "Shipping Cost; "; }

                        lblCostOut.Text = string.Format("{0, 0:c}", myPurchasedProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        MessageBox.Show(resultMsg, "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (i != myMfgProduct.ProductNumber)
                    {
                        MessageBox.Show("Product number supplied does not exist!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    //mfg product change message processing
                    if (i == myMfgProduct.ProductNumber)
                    {
                        if (txtDescription.Text != "")
                        {
                            myMfgProduct.Description = txtDescription.Text;
                            ynDescrip = true;
                        }
                        else
                        {
                            ynDescrip = false;
                        }

                        if (txtOnHand.Text != "")
                        {
                            myMfgProduct.OnHandQuantity = Convert.ToDouble(txtOnHand.Text);
                            ynOnHand = true;
                        }
                        else
                        {
                            ynOnHand = false;
                        }

                        if (txtUnitOfMeasure.Text != "")
                        {
                            myMfgProduct.UnitOfMeasure = txtUnitOfMeasure.Text;
                            ynUnit = true;
                        }
                        else
                        {
                            ynUnit = false;
                        }

                        if (txtOverhead.Text != "")
                        {
                            myMfgProduct.OverHeadPercent = Convert.ToDouble(txtOverhead.Text);
                            ynOverHead = true;
                        }
                        else
                        { 
                            ynOverHead = false; 
                        }

                        if (txtMfgCost.Text != "")
                        {
                            myMfgProduct.ManufacturedCost = Convert.ToDouble(txtMfgCost.Text);
                            ynMfgCost = true;
                        }
                        else
                        { ynMfgCost = false; }
                        
                        //build feedback message
                        if (ynDescrip)
                        {
                            resultMsg = resultMsg + "Description; ";
                        }

                        if (ynOnHand)
                        {
                            resultMsg = resultMsg + "On hand; ";
                        }

                        if (ynUnit)
                        { resultMsg = resultMsg + "Unit of Measure; "; }

                        if (ynOverHead)
                        { resultMsg = resultMsg + "Overhead %; "; }

                        if (ynMfgCost)
                        { resultMsg = resultMsg + "Mfg Cost; "; }

                        lblCostOut.Text = string.Format("{0, 0:c}", myMfgProduct.calcStdCost());
                        lblCostOut.Visible = true;

                        MessageBox.Show(resultMsg, "Change", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (i != myPurchasedProduct.ProductNumber)
                    {
                        MessageBox.Show("Product number supplied does not exist!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Product number MUST be a number!", "Product Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            txtDescription.Text = "";
            txtOnHand.Text = "";
            txtProductNumber.Text = "";
            txtUnitOfMeasure.Text = "";
            txtVendorId.Text = "";
            txtPurchPrice.Text = "";
            txtTaxRate.Text = "";
            txtShipping.Text = "";
            txtOverhead.Text = "";
            txtMfgCost.Text = "";
            lblCostOut.Visible = false;

        }//end change

    }//end form class
}
