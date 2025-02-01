using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steel_profiles
{
    public class RectangleHollowProfile
    {
        #region PROPERTIES
        public double b { get; set; }
        public double h { get; set; }
        public double t { get; set; }
        public double L { get; set; }

        #endregion

        #region CONSTRUCTORS

        public RectangleHollowProfile(double b, double y, double t, double L)
        {
            this.b = b;
            this.h = y;
            this.t = t;
            this.L = L;

        }
        #endregion

        #region RECTANGLE HP METHODS



        //Method to calculate cross section

        public double GetCrossSectionArea()
        {

      
            return (this.b * h - (b - 2 * t) * (h - 2 * t)) * 0.000001;

        }

        //Method to calculate volume
        public double GetVolume()
        {
            
           return GetCrossSectionArea() * (this.L * 0.001);
        }


        public void GetProfileInfo()
        {
           Console.WriteLine($"Profile dimensions: b = {this.b}, h = {this.h}, t = {this.t}, L = {this.L}");


        }
        #endregion






    }
}
