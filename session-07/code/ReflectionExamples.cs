using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace session_07
{
    public class ReflectionExamples
    {
        public static void Example()
        {
            #region Type

            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);
            //System.Int32

            #endregion


            #region Creating Instances

            // create instance of class DateTime
            DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));

            #endregion


            #region Properties

            Type calcType = Assembly.GetExecutingAssembly().GetType("session_07.Calculator");
            object calcInstance = Activator.CreateInstance(calcType);

            // get info about property: public double Number
            PropertyInfo numberPropertyInfo = calcType.GetProperty("Number");

            // get value of property: public double Number
            double value = (double)numberPropertyInfo.GetValue(calcInstance, null);

            // set value of property: public double Number
            numberPropertyInfo.SetValue(calcInstance, 10.0, null);

            #endregion
        }
    }

    public class Calculator
    {
        public Calculator() {  }
        private double _number;
        public double Number { get; set; }
        public void Clear() {  }
        private void DoClear() {  }
        public double Add(double number) { return number; }
        public static double Pi { get => Math.PI; }
        public static double GetPi() { return Pi; }
    }
}
