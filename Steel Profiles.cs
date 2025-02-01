using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steel_profiles
{
    public abstract class SteelProfiles
    {
        #region COMMON PROPERTIES
        //common property for steel density
        protected double p { get; } = 7850;

        //get currency and price from the user
        public string currency { get; set; }
        public double price { get; set; }

        #endregion

        #region PUBLIC PROPERTIES PROPERTIES

        //property to show profile weigth
        public string Weight
        {
            get

             {
                return "Profile wight is " + Convert.ToString(GetWeight()) + " kg";
            }

        }

        //property to show cross section area
        public string CrossSectionArea
        {
            get

           {
                return "Profile cross section area is " + Convert.ToString(GetCrossSectionArea()) + " m2";
            }

        }

        //property to show volume
        public string Volume
        {
            get

            {
                return "Profile volume is " + Convert.ToString(GetVolume()) + " m3";
           }

        }


        //property to show price
        public string MaterialCost
        {
            get

            {
                return "Total cost of the material is " + Convert.ToString(GetMaterialCost()) + " " + currency;
               
            }

        }

        #endregion

        #region ABSTRACT METHODS

        protected abstract double GetCrossSectionArea();

        protected abstract double GetVolume();

        protected abstract void GetProfileInfo();

        #endregion

        #region METHODS

        //method to get weight
        protected double GetWeight()
        {
           return GetVolume() * p;

        }

        //method to get material cost
        protected double GetMaterialCost()
        {

           return price * GetWeight();
        }

        #endregion

    }
}
