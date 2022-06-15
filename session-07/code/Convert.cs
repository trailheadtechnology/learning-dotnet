using System;

namespace session_07
{
    public class ConvertExample
    {

        public void Main()
        {
            //expanding conversions (smaller set of values to a larger set) - SAFE, casting
            //contracting conversions (larger set to a smaller set) - POTENTIALLY UNSAFE, have to convert

            double dNumber = 23.15;

            try
            {
                // Returns 23
                int iNumber = Convert.ToInt32(dNumber);
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                            "Overflow in double to int conversion.");
            }
            // Returns True
            bool bNumber = Convert.ToBoolean(dNumber);

            // Returns "23.15"
            string strNumber = Convert.ToString(dNumber);

            try
            {
                // Returns '2'
                char chrNumber = Convert.ToChar(strNumber[0]);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("String is null");
            }
            catch (FormatException)
            {
                Console.WriteLine("String length is greater than 1.");
            }

            // Console.ReadLine() returns a string and it
            // must be converted.
            int newInteger = 0;
            try
            {
                Console.WriteLine("Enter an integer:");
                newInteger = Convert.ToInt32(
                                    Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("String is null.");
            }
            catch (FormatException)
            {
                Console.WriteLine("String does not consist of an " +
                                "optional sign followed by a series of digits.");
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                "Overflow in string to int conversion.");
            }
            catch (Exception ex)
            {
                // log ex.ToString()
                //everything else
            }

            Console.WriteLine("Your integer as a double is {0}",
                                     Convert.ToDouble(newInteger));
        }
    }
}
