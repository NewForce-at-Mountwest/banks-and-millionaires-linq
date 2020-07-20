using System;
using System.Collections.Generic;
using System.Linq;

namespace groupby_linq
{
    // Build a collection of customers who are millionaires
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>() {
        new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
        new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
        new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
        new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
        new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
        new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
        new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
        new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
        new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
        new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            // Step 1: filter customers list to contain only millionaires
            List<Customer> millionaires = customers.Where(singleCustomer => singleCustomer.Balance >= 1000000).ToList();

            // var banksAndTheirMillionaireCounts = millionaires.GroupBy(
            //     singleCustomer => singleCustomer.Bank,
            //     (key, customerList) => new Dictionary<string, int>(){
            //         {key, customerList.ToList().Count()}
            //     }).ToList();

            var banksAndTheirMillionaireCounts = from singleMillionaire in customers
                                                 where singleMillionaire.Balance > 1000000
                                                 group singleMillionaire by singleMillionaire.Bank into bankReport
                                                 select new Dictionary<string, int>() { { bankReport.Key, bankReport.Count() } };
          



            // var banksAndTheirMillionaireCounts = millionaires.GroupBy(millionaire => millionaire.Bank).ToList();


            // banksAndTheirMillionaireCounts.ForEach(bank => Console.WriteLine($"{bank.Key} - {bank.Count()}"));


            Console.WriteLine();






            // Step 2: Sort the millionaires into buckets by bank

            // Step 3: Count the millionaires at each bank

            //  Example Output:
            // WF 2
            // BOA 1
            // FTB 1
            // CITI 1





        }
    }
}
