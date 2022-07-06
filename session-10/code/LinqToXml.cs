using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace session_10
{
    public class LinqToXml
    {
        public static void Example()
        {
            // Load the XML file from our project directory containing the purchase orders
            var filename = "PurchaseOrder.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var purchaseOrderFilepath = Path.Combine(currentDirectory, filename);

            XElement purchaseOrder = XElement.Load(purchaseOrderFilepath);

            IEnumerable<string> partNos = from item in purchaseOrder.Descendants("Item")
                                          select (string)item.Attribute("PartNumber");

            foreach (var partNo in partNos)
            {
                Console.WriteLine(partNo);
            }
        }
    }
}
