using System;
using System.Collections.Generic;

namespace Collection_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, cityinfo> mydict = new Dictionary<string, cityinfo>();
            mydict.Add("Ottawa", new cityinfo() { Population = 100000, Province = "ON" });
            mydict.Add("Calgary", new cityinfo() { Population = 200000, Province = "AB" });
            mydict.Add("Toronto", new cityinfo() { Population = 300000, Province = "ON" });




            foreach (KeyValuePair<string, cityinfo> kvp in mydict)
            {
                Console.WriteLine($"{kvp.Key} is a city in {kvp.Value.Province}");
            }


            HashSet<string> Northamericancity=new HashSet<string>();

            Northamericancity.Add("Chicago");
            Northamericancity.Add("Mexico");
            Northamericancity.Add("New York");
            Northamericancity.Add("Los Angeles");
            Northamericancity.Add("Boston");
            Northamericancity.Add("Dallas");
            Northamericancity.Add("Houston");
            Northamericancity.Add("Calgary");
            Northamericancity.Add("Toronto");
            Northamericancity.Add("Ottawa");

            HashSet<string> canadacapital = new HashSet<string>(mydict.Keys);

            canadacapital.IntersectWith(Northamericancity);
           // canadacapital.UnionWith(Northamericancity);


            foreach (string item in canadacapital )
            {
                Console.WriteLine(item);
            }
        }
    }
    class cityinfo
    {
        public int Population { get; set; }
        public string Province { get; set; }
    }
}
