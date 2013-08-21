/* 
 * Name: Alexander D. Martinez
 * Date: 10/27/09
 * Purpose: learn about inheretance
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class PurchasedProduct : Product
    {
        //private variables
        private int vendId;
        private double purchPrice;
        private double taxRa;
        private double shipCo;

        //property methods
        public int VendorId
        {
            get { return vendId; }
            set { vendId = value; }
        }

        public double PurchasePrice
        {
            get { return purchPrice; }
            set { purchPrice = value; }
        }

        public double TaxRate
        {
            get { return taxRa; }
            set { taxRa = value; }
        }

        public double ShippingCost
        {
            get { return shipCo; }
            set { shipCo = value; }
        }

        //constructors
        public PurchasedProduct()
        {
            vendId = 0;
            purchPrice = 0.0;
            taxRa = 0.0;
            shipCo = 0.0;
        }

        public PurchasedProduct(int vId, double pPri, double tRate, double ship)
        {
            if (vId >= 0)
            {
                VendorId = vId;
            }
            else
            {
                VendorId = 0;
            }

            if (pPri >= 0)
            {
                PurchasePrice = pPri;
            }
            else
            { PurchasePrice = 0.0; }

            if (tRate >= 0 && tRate <= 1)
            {
                TaxRate = tRate; 
            }
            else
            { TaxRate = 0.0; }

            if (ship >= 0)
            {
                ShippingCost = ship; 
            }
            else
            { ShippingCost = 0.0; }
        }        

        public PurchasedProduct(int vId, double pPri, double tRate, double ship, int pNum, string descrip, double onHan, string uOfM)
            : base(pNum, descrip, onHan, uOfM)
        {
            if (vId >= 0)
            {
                VendorId = vId;
            }
            else
            {
                VendorId = 0;
            }

            if (pPri >= 0)
            {
                PurchasePrice = pPri;
            }
            else
            { PurchasePrice = 0.0; }

            if (tRate >= 0 && tRate <= 1)
            {
                TaxRate = tRate;
            }
            else
            { TaxRate = 0.0; }

            if (ship >= 0)
            {
                ShippingCost = ship;
            }
            else
            { ShippingCost = 0.0; }            
            
        }

        //override ToString
        public override string ToString()
        {
            return base.ToString() + string.Format(" {0} {1} {2} {3}", VendorId, PurchasePrice, TaxRate, ShippingCost);
        }

        public override double calcStdCost()
        {
            double result;
            result = PurchasePrice * (1 + TaxRate) + ShippingCost;
            return result;
        }

    }
}

/*Override the calcStdCost method of the Product class. 
 * This version should calculate and return the cost as: purchase price * (1 + tax rate) + shipping cost.*/