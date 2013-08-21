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
    class MfgProduct : Product
    {
        //variables
        private double manuCost;
        private double oHeadPerc;

        //property methods

        public double ManufacturedCost
        {
            get { return manuCost; }
            set { manuCost = value; }
        }

        public double OverHeadPercent
        {
            get { return oHeadPerc; }
            set { oHeadPerc = value; }
        }

        //constructors
        public MfgProduct()
        {
            manuCost = 0;
            oHeadPerc = 0;
        }

        public MfgProduct(double manCo, double ovHdPer)
        {
            if (manCo >= 0)
            {
                ManufacturedCost = manCo;
            }
            else { ManufacturedCost = 0; }

            if (ovHdPer >= 0 && ovHdPer <= 1)
            {
                OverHeadPercent = ovHdPer;
            }
            else { OverHeadPercent = 0; }
        }

        public MfgProduct(double manCo, double ovHdPer, int pNum, string descrip, double onHan, string uOfM)
            : base(pNum, descrip, onHan, uOfM)
        {
            if (manCo >= 0)
            {
                ManufacturedCost = manCo;
            }
            else { ManufacturedCost = 0; }

            if (ovHdPer >= 0 && ovHdPer <= 1)
            {
                OverHeadPercent = ovHdPer;
            }
            else { OverHeadPercent = 0; }
        }

        //override methods
        public override string ToString()
        {
            return base.ToString() + string.Format(" {0} {1}", ManufacturedCost, OverHeadPercent);
        }

        public override double calcStdCost()
        {
            double result;
            result = ManufacturedCost * (1 + OverHeadPercent);
            return result;
        }

    }
}