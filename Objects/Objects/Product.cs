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
    class Product
    {
        private int prodNum;
        private string desc;
        private double onHand;
        private string unit;

        //property methods
        public int ProductNumber
        {
            get { return prodNum; }

            set
            {
                if (value >= 0)
                    prodNum = value;
            }
        }

        public string Description
        {
            get { return desc; }

            set
            {
                if (value != "" || value != null)
                    desc = value;
            }
        }

        public double OnHandQuantity
        {
            get { return onHand; }

            set
            {
                if (value >= 0)
                    onHand = value;
            }
        }

        public string UnitOfMeasure
        {
            get { return unit; }
            set
            {
                if (value != "" || value != null)
                    unit = value;
            }
        }


        //Constructors
        public Product()
        {
            prodNum = 0;
            onHand = 0;
            desc = "no description";
            unit = "no unit of measure";
        }

        public Product(int prodNumIn, string descIn, double onHandIn, string unitIn)
        {
            ProductNumber = prodNumIn;
            Description = descIn;
            OnHandQuantity = onHandIn;
            UnitOfMeasure = unitIn;
        }

        //methods
        public virtual double calcStdCost()
        {
            //return 0.0 ?
            return 0.0;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", ProductNumber, Description, OnHandQuantity, UnitOfMeasure);
        }


    }//End Class
}//End namespace