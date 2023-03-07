using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session4.String2;

namespace Session4
{
	internal class NullExamples
	{
		public void Main()
		{
			//int i;
			int i = 0;

			string s = ""; //same as String.Empty

			SampleClass sampleClass2; // same
			SampleClass sampleClass = null; //same
			
			if (i == 0)
			{

			}

			if (sampleClass is null)
			{

			}

			// null coalescing operator ??
			if (sampleClass is not null)
			{
				sampleClass.Name = "J.";
			}

			string myString = null;
			string result1 = myString ?? "default1";
			string result2 = "" ?? "default2";
			int? i2 = null;
			int result3 = i2 ?? 0;
		}
	}
}
