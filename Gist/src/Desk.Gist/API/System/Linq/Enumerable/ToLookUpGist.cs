using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Gist.API.System.Linq.Enumerable
{
    public class ToLookUpGist
    {
        class Package
        {
            public string Company { get; set; }
            public double Weight { get; set; }
            public long TrackingNumber { get; set; }
        }
        public static void ToLookupGist()
        {
            // Create a list of Packages.
            List<Package> packages =
                new List<Package>
                    { new Package { Company = "Coho Vineyard",
                  Weight = 25.2, TrackingNumber = 89453312L },
              new Package { Company = "Lucerne Publishing",
                  Weight = 18.7, TrackingNumber = 89112755L },
              new Package { Company = "Wingtip Toys",
                  Weight = 6.0, TrackingNumber = 299456122L },
              new Package { Company = "Contoso Pharmaceuticals",
                  Weight = 9.3, TrackingNumber = 670053128L },
              new Package { Company = "Wide World Importers",
                  Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Lookup to organize the packages.
            // Use the first character of Company as the key value.
            // Select Company appended to TrackingNumber
            // as the element values of the Lookup.
            ILookup<char, string> lookup =
                packages
                .ToLookup(p => Convert.ToChar(p.Company.Substring(0, 1)),
                          p => p.Company + " " + p.TrackingNumber);

            // Iterate through each IGrouping in the Lookup.
            foreach (IGrouping<char, string> packageGroup in lookup)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(packageGroup.Key);
                // Iterate through each value in the
                // IGrouping and print its value.
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }
        }


        public static void ToLookupGist2()
        {
            var ticketlist = GetList();
            var dic = ticketlist.ToLookup(i => i.OrderID);
            foreach (var item in dic)
            {
                Console.WriteLine("订单号:" + item.Key);

                foreach (var item1 in item)
                {
                    Console.WriteLine("\t\t" + item1.TicketNo + "  " + item1.Description);
                }
            }
        }
        private static List<Ticket> GetList()
        {
            return new List<Ticket>()
            {
                 new Ticket(){ TicketNo="999-12311",OrderID=79121281,Description="改签"},
                 new Ticket(){ TicketNo="999-24572",OrderID=29321289,Description="退票"},
                 new Ticket(){ TicketNo="999-68904",OrderID=19321289,Description="成交"},
                 new Ticket(){ TicketNo="999-24172",OrderID=64321212,Description="未使用"},
                 new Ticket(){ TicketNo="999-24579",OrderID=19321289,Description="退票"},
                 new Ticket(){ TicketNo="999-21522",OrderID=79121281,Description="未使用"},
                 new Ticket(){ TicketNo="999-24902",OrderID=79121281,Description="退票"},
                 new Ticket(){ TicketNo="999-04571",OrderID=29321289,Description="改签"},
                 new Ticket(){ TicketNo="999-23572",OrderID=96576289,Description="改签"},
                 new Ticket(){ TicketNo="999-24971",OrderID=99321289,Description="成交"}
            };
        }
        class Ticket
        {
            /// <summary>
            /// 票号
            /// </summary>
            public string TicketNo { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            public int OrderID { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            public string Description { get; set; }
        }
    }
}
