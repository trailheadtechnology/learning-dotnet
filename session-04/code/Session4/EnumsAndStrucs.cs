using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    public class EnumsAndStrucs
    {
        public const string CELCIUS = "c";
        public const string FAHRENHEIT = "f";

        public struct Temperature
        {
            public double Temp;
            public TemperatureScale Scale;

            public Temperature(double temp, TemperatureScale scale)
            {
                Temp = temp;
                Scale = scale;
            }
        }

        public void Main()
        {
            var temp = new Temperature(35, TemperatureScale.Celcius);
            var temp2 = new Temperature(35, TemperatureScale.Fahrenheit);
        }

        public enum TemperatureScale
        {
            Celcius, 
            Fahrenheit,
        }

        public enum UserStatuses : short
        {
            Active = 10,
            InReview = -10,
            Inactive = 0,
        }

        public class User
        {
            public UserStatuses Status { get; set; }
        }

        public User GetUserFromDB()
        {
            return new User();
        }

        public void Main2()
        {
            var t = new Temperature(35, TemperatureScale.Fahrenheit);
            var t2 = ConvertTo(t, TemperatureScale.Celcius);

            var user = GetUserFromDB();
            if (user.Status == UserStatuses.InReview)
            {
                if (user.Status.ToString() == "Active")
                {

                }
                var x = (short)user.Status * 10;
            }

            //var converted2 = ConvertTemp2(0.0f, CELCIUS, FAHRENHEIT);
            //var converted3 = ConvertTemp2(0.0f, "test", "notvalid");
        }

        public Temperature ConvertTo(Temperature original, TemperatureScale targetScale)
        {
            if (targetScale == original.Scale) return original;

            Temperature newTemp;
            if (targetScale == TemperatureScale.Fahrenheit)
            {
                //do conversion to C
                newTemp = new Temperature(1, TemperatureScale.Celcius);
            }
            else
            {
                //do conversion to F
                newTemp = new Temperature(1, TemperatureScale.Fahrenheit);
            }
            return newTemp;
        }
    }

  
}
