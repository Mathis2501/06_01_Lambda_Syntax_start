using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        #region Class Definitions
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string State { get; set; }
            public double Price { get; set; }
            public string[] Purchases { get; set; }
        }

        public class Distributor
        {
            public string Name { get; set; }
            public string State { get; set; }
        }

        public class CustDist
        {
            public string custName { get; set; }
            public string distName { get; set; }
        }

        public class CustDistGroup
        {
            public string custName { get; set; }
            public IEnumerable<string> distName { get; set; }
        }
        #endregion

        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {First = "Theodore", Last = "Trock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Bulb 23W", "Panel 200"}},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}}
        };

        static List<Distributor> distributors = new List<Distributor>
        {
            new Distributor {Name = "Edgepulse", State = "UT"},
            new Distributor {Name = "Jabbersphere", State = "GA"},
            new Distributor {Name = "Quaxo", State = "FL"},
            new Distributor {Name = "Yakijo", State = "OR"},
            new Distributor {Name = "Scaboo", State = "GA"},
            new Distributor {Name = "Innojam", State = "WA"},
            new Distributor {Name = "Edgetag", State = "WA"},
            new Distributor {Name = "Leexo", State = "HI"},
            new Distributor {Name = "Abata", State = "OR"},
            new Distributor {Name = "Vidoo", State = "TX"}
        };

        static double[] exchange = { 0.89, 0.65, 120.29 };

        static double[] ExchangedPrices = {827.70, 604.50, 111869.70,
                                        1869.00, 1,365.00, 252609.00,
                                        521.36, 380.77, 70465.88,
                                        455.68, 332.80, 61588.48,
                                        2018.34, 1474.07, 272793.66,
                                        920.26, 672.10, 124379.86,
                                        1873.45, 1368.25, 253210.45,
                                        149.34, 109.07, 20184.66,
                                        455.68, 332.80, 61588.48,
                                        525.28, 383.63, 70995.16,
                                        9.08, 6.63, 1226.96,
                                        311.50, 227.50, 42101.50};

        static string[] Purchases = {  "Panel 625", "Panel 200",
                                    "12V Li",
                                    "Bulb 23W", "Panel 625",
                                    "Panel 200", "Panel 180",
                                    "Bulb 23W", "12V Li", "Panel 180",
                                    "Panel 625",
                                    "12V Li", "AA NiMH",
                                    "Bulb 23W", "Panel 180",
                                    "Panel 180", "Panel 200",
                                    "Panel 625", "Bulb 23W", "Bulb 9W",
                                    "Bulb 23W", "Bulb 9W",
                                    "Panel 200"
                                 };
        #endregion

        static void Main(string[] args)
        {
            // LINQ

                #region GetExchangedLessThan1000

                //var Query =
                //    from s in ExchangedPrices
                //    where s < 1000
                //    select s;

                //foreach (var s in Query)
                //{
                //    Console.WriteLine(s);
                //}


                #endregion

                #region GetAllCustomersPurchaseFromGA

                //var Query =
                //    from s in customers
                //    where s.State == "GA"
                //    select s;


                //foreach (var s in Query)
                //{
                //    Console.WriteLine(s.First + " " + s.Last);

                //    foreach (var i in s.Purchases)
                //    {
                //        Console.WriteLine("   " + i);
                //    }
                //}

                #endregion

                #region GetFirstNameOfCustomers

                //var Query =
                //    from s in customers
                //    select s.First;

                //foreach (var s in Query)
                //{
                //    Console.WriteLine(s);
                //}

                #endregion

                #region CombineFirstAndLastToFullName

                //var Query =
                //    from customer in customers
                //    select new {Full = customer.First + " " + customer.Last};

                //foreach (var s in Query)
                //{
                //    Console.WriteLine(s.Full);
                //}

                #endregion

                #region GetStateAbbreviationsWithCustomers

                //var Query =
                //    from distributor in distributors
                //    select distributor.State;


                //foreach (var s in Query)
                //{
                //    Console.WriteLine(s);

                //    foreach (var c in customers)
                //    {
                //        if (c.State == s)
                //        {
                //            Console.WriteLine("   " + c.First + " " +  c.Last);
                //        }
                //    }
                //}

                #endregion

                #region TakeFirst3

                //var Query = customers.Take(3);

                //foreach (var c in Query)
                //{
                //    Console.WriteLine(c.First + " " + c.Last);
                //}

                #endregion

                #region TakeFirst3FromOR

                //var Query =
                //    from customer in customers
                //    where customer.State == "OR"
                //    select customer;

                //int timesThrough = 0;

                //foreach (var c in Query)
                //{
                //    if (timesThrough < 3)
                //    {
                //        Console.WriteLine($"{c.First} {c.Last} {c.State}");
                //        timesThrough++;
                //    }
                //}

                #endregion

                #region OrderByFirstName

                //var Query =
                //    from customer in customers
                //    orderby customer.First
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine($"{c.First} {c.Last}");
                //}

                #endregion

                #region OrderByLengthOfLastName

                //var Query =
                //    from customer in customers
                //    orderby customer.Last.Length
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine($"{c.First} {c.Last}");
                //}

                #endregion

                #region OrderByPrice

                //var Query =
                //    from customer in customers
                //    orderby customer.Price
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine(c.Price);
                //}

                #endregion

                #region OrderByLengthOfFirstThenByLast

                //var Query =
                //    from customer in customers
                //    orderby customer.First.Length, customer.Last
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine($"{c.First} {c.Last}");
                //}

                #endregion

                #region GroupByfirstLetterInFirstName

                //var Query =
                //    from customer in customers
                //    group customer by customer.First[0]
                //    into customer
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine(c.Key);

                //    foreach (var i in c)
                //    {
                //        Console.WriteLine($"   {i.First} {i.Last}");
                //    }
                //}

                #endregion

                #region GroupCustomersByState

                //var Query =
                //    from customer in customers
                //    group customer by customer.State
                //    into customer
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine(c.Key);
                //    foreach (var i in c)
                //    {
                //        Console.WriteLine($"   {i.First} {i.Last}");
                //    }
                //}

                #endregion

                #region ExceptAnyWhereFirstLetterInFirstnameEqualsFirstLetterInLastname

                //var Query =
                //    from customer in customers
                //    where customer.First[0] != customer.Last[0]
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine($"{c.First} {c.Last}");
                //}

                #endregion

                #region AnyThatContainsED

                //var Query =
                //    from customer in customers
                //    where customer.First.Contains("ed")
                //    select customer;

                //foreach (var c in Query)
                //{
                //    Console.WriteLine($"{c.First} {c.Last}");
                //}

                #endregion

            // Lambda

                #region GetExchangedLessThan1000

            //Get exchanged prices for less than 1000
            //IEnumerable<double> lessThan1000 = ExchangedPrices.Where(p => p < 1000);
            //foreach (double c in lessThan1000)
            //{
            //    Console.WriteLine(c);
            //}

                #endregion

                #region GetAllCustomersPurchasesFromGA

            //IEnumerable<Customer> GetCustomersFromGA = customers.Where(c => c.State == "GA");
            //IEnumerable<string[]> GetPurchasesFromGA = GetCustomersFromGA.Select(p => p.Purchases);

            //foreach (Customer c in GetCustomersFromGA)
            //{
            //    Console.WriteLine("{0} {1}", c.First, c.Last);
            //    foreach (var purchase in c.Purchases)
            //    {
            //        Console.WriteLine("   " + purchase);
            //    }
            //}

                #endregion

                #region GetFirstNamesOfCustomers

            //IEnumerable<string> GetFirstNameQuery = customers.Select(c => c.First);
            //foreach (var Name in GetFirstNameQuery)
            //{
            //    Console.WriteLine(Name);
            //}

                #endregion

                #region CombineFirstAndLastToFullName

            //var CombineAndGetFullNameQuery = customers.Select(x => new { Full = x.First + " " + x.Last });
            //foreach (var s in CombineAndGetFullNameQuery)
            //{
            //    Console.WriteLine(s.Full);
            //}

                #endregion

                #region GetStateAbreviationsWithCustomers

            //var GetStateAbbreviationWithCustomersQuery = distributors.Select(x => x.State);

            //foreach (var state in GetStateAbbreviationWithCustomersQuery)
            //{
            //    Console.WriteLine(state);

            //    foreach (var c in customers)
            //    {
            //        if (c.State == state)
            //        {
            //            Console.WriteLine("   " + c.First + " " + c.Last);
            //        }
            //    }
            //}

                #endregion

                #region TakeFirst3

            //var takeFirst3Query = customers.Take(3);

            //foreach (var c in takeFirst3Query)
            //{
            //    Console.WriteLine(c.First, c.Last);
            //}

                #endregion

                #region TakeFirst3FromOR

            //var TakeFirst3FromOR = customers.Where(x => x.State == "OR").Take(3);

            //foreach (var c in TakeFirst3FromOR)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region OrderByFirstName

            //var OrderByFirstNameQuery = customers.OrderBy(x => x.First);

            //foreach (var c in OrderByFirstNameQuery)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region OrderByLengthOfLastName

            //var OrderByLengthOfLastQuery = customers.OrderBy(x => x.Last.Length);

            //foreach (var c in OrderByLengthOfLastQuery)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region OrderByPrice

            //var OrderByPrice = customers.OrderByDescending(x => x.Price);

            //foreach (var c in OrderByPrice)
            //{
            //    Console.WriteLine(c.Price);
            //}

                #endregion

                #region OrderByLengthOfFirstThenByLast

            //var OrderByFirstAndLast = customers.OrderBy(x => x.First.Length).ThenBy(x => x.Last);

            //foreach (var c in OrderByFirstAndLast)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region GroupByfirstLetterInFirstName

            //var GroupByFirstLetter = customers.OrderBy(x => x.First).GroupBy(x => x.First[0]);

            //foreach (var c in GroupByFirstLetter)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var i in c)
            //    {
            //        Console.WriteLine("  " + i.First);
            //    }
            //}

                #endregion

                #region GroupCustomersByState

            //var GroupByState = customers.OrderBy(x => x.First).GroupBy(x => x.State);

            //foreach (var c in GroupByState)
            //{
            //    Console.WriteLine(c.Key);
            //    foreach (var i in c)
            //    {
            //        Console.WriteLine("   " + i.First);
            //    }
            //}

                #endregion

                #region ExceptAnyWhereFirstLetterInFirstnameEqualsFirstLetterInLastname

            //var exception = customers.Where(x => x.First[0] == x.Last[0]);
            //var FirstFirstFirstLast = customers.Except(exception);

            //foreach (var c in FirstFirstFirstLast)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region AnyThatContainsED

            //var AnyThatContains = customers.Any(x => x.First.Contains("ed"));

            //Console.WriteLine(AnyThatContains.ToString());

                #endregion

            // !LINQ and Lambda

                #region GetExchangedLessThan1000

            //foreach (var p in ExchangedPrices)
            //{
            //    if (p < 1000)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}

                #endregion

                #region GetAllCustomersPurchasesFromGA

            //foreach (var c in customers)
            //{

            //    Console.WriteLine(c.First + " " + c.Last);
            //    foreach (var p in c.Purchases)
            //    {
            //        Console.WriteLine("   " + p);
            //    }
            //}

                #endregion

                #region GetFirstNamesOfCustomers

            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c.First);
            //}

                #endregion

                #region CombineFirstAndLastToFullName

            //string Full;

            //foreach (var c in customers)
            //{
            //    Full = c.First + " " + c.Last;
            //    Console.WriteLine(Full);
            //}

                #endregion

                #region GetStateAbreviationsWithCustomers

            //foreach (var d in distributors)
            //{
            //    Console.WriteLine(d.Name + " " + d.State);
            //    foreach (var c in customers)
            //    {
            //        if (c.State == d.State)
            //        {
            //            Console.WriteLine("   " + c.First + " " + c.Last);
            //        }
            //    }
            //}

                #endregion

                #region TakeFirst3

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(customers[i].First + " " + customers[i].Last);
            //}

                #endregion

                #region TakeFirst3FromOR

            //int amountTaken = 0;

            //foreach (var c in customers)
            //{
            //    if (c.State == "OR" && amountTaken < 3)
            //    {
            //        Console.WriteLine(c.First + " " + c.Last);

            //        amountTaken++;
            //    }
            //}

                #endregion

                #region OrderByFirstName

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.First == null && y.First == null) return 0;
            //    else if (x.First == null) return -1;
            //    else if (y.First == null) return 1;
            //    else return x.First.CompareTo(y.First);
            //});

            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region OrderByLengthOfLastName

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.Last.Length == null && y.Last.Length == null) return 0;
            //    else if (x.Last.Length == null) return -1;
            //    else if (y.Last.Length == null) return 1;
            //    else return x.Last.Length.CompareTo(y.Last.Length);
            //});

            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c.First + " " + c.Last);
            //}

                #endregion

                #region OrderByPrice

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.Price == null && y.Price == null) return 0;
            //    else if (x.Price == null) return -1;
            //    else if (y.Price == null) return 1;
            //    else return x.Price.CompareTo(y.Price);
            //});

            //foreach (var c in customers)
            //{
            //    Console.WriteLine(c.First + " " + c.Last + " " + c.Price);
            //}

                #endregion

                #region OrderByLengthOfFirstThenByLast

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.Last == null && y.Last == null) return 0;
            //    else if (x.Last == null) return -1;
            //    else if (y.Last == null) return 1;
            //    else return x.Last.CompareTo(y.Last);
            //});

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.First.Length == null && y.First.Length == null) return 0;
            //    else if (x.First.Length == null) return -1;
            //    else if (y.First.Length == null) return 1;
            //    else return x.First.Length.CompareTo(y.First.Length);
            //});

            //foreach (var c in customers)
            //{
            //    Console.WriteLine($"{c.First} {c.Last} {c.Price}");
            //}

                #endregion

                #region GroupByfirstLetterInFirstName

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.First == null && y.First == null) return 0;
            //    else if (x.First == null) return -1;
            //    else if (y.First == null) return 1;
            //    else return x.First.CompareTo(y.First);
            //});

            //char currentChar = 'A';
            //bool first = true;

            //foreach (var c in customers)
            //{
            //    if (currentChar != c.First[0] || first)
            //    {
            //        Console.WriteLine(c.First[0]);
            //        currentChar = c.First[0];
            //        first = false;
            //    }

            //    Console.WriteLine("   " + c.First + " " + c.Last);
            //}

                #endregion

                #region GroupCustomersByState

            //string currentState = "";
            //bool first = true;

            //customers.Sort(delegate (Customer x, Customer y)
            //{
            //    if (x.State == null && y.State == null) return 0;
            //    else if (x.State == null) return -1;
            //    else if (y.State == null) return 1;
            //    else return x.State.CompareTo(y.State);
            //});

            //foreach (var c in customers)
            //{
            //    if (currentState != c.State || first)
            //    {
            //        Console.WriteLine(c.State);
            //        currentState = c.State;
            //        first = false;
            //    }

            //    Console.WriteLine("   " + c.First + " " + c.Last);
            //}

                #endregion

                #region ExceptAnyWhereFirstLetterInFirstnameEqualsFirstLetterInLastname

            //foreach (var c in customers)
            //{
            //    if (c.First[0] != c.Last[0])
            //    {
            //        Console.WriteLine(c.First + " " + c.Last);
            //    }
            //}

                #endregion

                #region AnyThatContainsED

            //foreach (var c in customers)
            //{
            //    if (c.First.Contains("ed"))
            //    {
            //        Console.WriteLine(c.First + " " + c.Last);
            //    }
            //}

                #endregion

            Console.ReadKey();
        }
    }
}
 