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
        public enum TemperatureScale
        {
            Celcius, Fahrenheit
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

        public void Main()
        {
            var converted = ConvertTemp(0.0f, 
                TemperatureScale.Celcius, 
                TemperatureScale.Fahrenheit);

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

        public float ConvertTemp(float fromValue, TemperatureScale from, TemperatureScale to)
        {
            // todo
            return 0.0f;
        }

        //public float ConvertTemp2(float fromValue, string from, string to)
        //{
        //    // todo
        //    return 0.0f;
        //}
    }

  
}
