using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            bool isThrown = false;
            try
            {
                string[] personsInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var person in personsInput)
                {
                    persons.Add(Person.AddPerson(person));
                }
                string[] ProductInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var product in ProductInput)
                {
                    products.Add(Product.AddProduct(product));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                isThrown = true;
            }  

            while (true)
            {
                if (isThrown)
                {
                    break;
                }   
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                if (input[0].ToLower() == "end")
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var person in persons)
                    {
                        if (person.Products.Count == 0)
                        {
                            Console.WriteLine($"{person.Name} - Nothing bought");
                            continue;
                        }

                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                    }
                    break;
                }
                string currPersonName = input[0];
                string currProductName = input[1];
                Person currPerson = persons.FirstOrDefault(x => x.Name == currPersonName);
                Product currProduct = products.FirstOrDefault(x => x.Name == currProductName);
                if (currPerson.Money >= currProduct.Cost)
                {
                    currPerson.Products.Add(new Product(currProductName));
                    currPerson.Money -= currProduct.Cost;
                    Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {currProduct.Name}");
                }

            }
        }
    }
}
