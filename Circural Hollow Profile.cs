using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steel_profiles
{
    public class CircuralHollowProfile
    {
        #region PROPERTIES

        public double r { get; set; }
        public double t { get; set; }
        public double L { get; set; }

        #endregion


        #region CONSTRUCTOR
        public CircuralHollowProfile(double r, double t, double L)
        {
            this.r = r;
            this.t = t;
            this.L = L;

        }

        #endregion


        #region CIRCURAL HP METHODS

        //Method to calculate cross section
        public double GetCrossSectionArea()
        { 
            
        return (Math.PI* Math.Pow(r,2)-(Math.PI* Math.Pow(r-t, 2)) * 0.000001);

        }

        //Method to calculate volume
        public double GetVolume()
        { 
         return GetCrossSectionArea() * this.L;
        
        }
        #endregion


    }
}
