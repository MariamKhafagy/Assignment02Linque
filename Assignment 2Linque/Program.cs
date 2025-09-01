using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2Linque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  ELement OPerators
            #region Q.1
            //1. Get first Product out of Stock 


            //var FirstOutOfStock = ListGenerator.ProductList
            //    .FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine("First Product Out OF Stock  : ");

            //if (FirstOutOfStock != null)
            //    Console.WriteLine(FirstOutOfStock);
            //else
            //    Console.WriteLine("No Product is Out Of Stock ");


            #endregion

            #region Q.2
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var ExpensiveProductPrice = ListGenerator.ProductList
            //    .FirstOrDefault(p => p.UnitPrice >1000);

            //if (ExpensiveProductPrice != null)
            //    Console.WriteLine($" First Product With Price >1000 : {ExpensiveProductPrice}");
            //else
            //    Console.WriteLine("No Product Has Price >1000");

            #endregion

            #region  Q.3
            //3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var SecondNumbergrt5 = Arr.Where(n => n > 5)
            //    .Skip(1)
            //    .FirstOrDefault();

            //Console.WriteLine($"Second number Gretear than 5 : {SecondNumbergrt5}");


            #endregion


            #endregion

            #region Aggregate Operators

            #region Q.1
            //1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int NumberOfOddnumbers = Arr.Count(n => n % 2 == 1);

            //Console.WriteLine($" Odd Numbers Count : {NumberOfOddnumbers}");

            #endregion

            #region Q.2
            //2. Return a list of customers and how many orders each has.

            //var ListOfCustomrs = ListGenerator.CustomerList
            //    .Select(c => new { c.CustomerName, OrdersCount = c.Orders.Count() });

            //foreach (var item in ListOfCustomrs)
            //    Console.WriteLine($"{item.CustomerName} has {item.OrdersCount} orders");

            #endregion

            #region Q.3
            //3. Return a list of categories and how many products each has

            //var ListOfCategories = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in ListOfCategories)
            //    Console.WriteLine($"{item.Category} : {item .Count} Products ");
            #endregion

            #region  Q.4
            //4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Sum();
            //Console.WriteLine($" Total ={total}");

            #endregion

            #region dictionary English.txt

            #region Q.5

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //int totalChars = Words.Sum(w => w.Length);
            //Console.WriteLine($"Total Character = {totalChars}");

            #endregion

            #region Q.6
            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //int Shorstest = Words.Min(w => w.Length);
            //Console.WriteLine($"Shortest Word Length is  : {Shorstest}");

            #endregion

            #region Q.7
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //int Longest=Words.Max(w => w.Length);
            //Console.WriteLine($"Longest Words Length is  : {Longest}");

            #endregion

            #region Q.8
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //double Average =Words.Average(w => w.Length);
            //Console.WriteLine($"The Average Word Length is {Average}");

            #endregion

            #endregion

            #region Q.9
            //9. Get the total units in stock for each product category.

            //var TotalUnitsinStock = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

            //foreach (var item in TotalUnitsinStock)
            //    Console.WriteLine($"{item.Category} : {item.TotalUnits} Units  in Stock");

            #endregion

            #region Q.10
            //10. Get the cheapest price among each category's products

            //var CheapestPriceCategory = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

            //foreach (var item in CheapestPriceCategory)
            //    Console.WriteLine($"{item.Category} : Cheapest {item.CheapestPrice}");

            #endregion

            #region Q.11
            //11. Get the products with the cheapest price in each category (Use Let)

            //var CheapestPricecategory = from p in ListGenerator.ProductList
            //                            group p by p.Category into g
            //                            let minPrice = g.Min(p => p.UnitPrice)
            //                            select new
            //                            {
            //                                Category = g.Key,
            //                                Products = g.Where(p => p.UnitPrice == minPrice)

            //                            };

            //foreach (var group in CheapestPricecategory)
            //{
            //    Console.WriteLine($"Category : {group.Category}");
            //    foreach (var Product in group.Products)
            //        Console.WriteLine($"{Product.ProductName} , {Product.UnitPrice}");
            //}


            #endregion

            #region Q.12
            //12. Get the most expensive price among each category's products.

            //var MaxExpensivePrice = ListGenerator.ProductList
            //                         .GroupBy(p => p.Category)
            //                         .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            //foreach (var item in MaxExpensivePrice)
            //    Console.WriteLine($"{item.Category} : Most expensive = {item.MaxPrice}");

            #endregion

            #region Q.13
            //13. Get the products with the most expensive price in each category.

            //var TheMOstExpensivePrice = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))
            //    });

            //foreach (var group in TheMOstExpensivePrice)
            //{
            //    Console.WriteLine($"Category : {group.Category}");
            //    foreach (var product in  group.Products)
            //        Console.WriteLine($" {product.ProductName} , {product.UnitPrice}");
            //}
            #endregion

            #region Q.14
            //14. Get the average price of each category's products.

            //var AvseragepriceCategory = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category=g.Key,
            //        AveragePrice=g.Average(p =>p.UnitPrice)
            //    });
            //foreach (var item in AvseragepriceCategory)
            //    Console.WriteLine($"{item.Category} : average Price = {item.AveragePrice}");

            #endregion


            #endregion

            #region Set OPeraters 

            #region Q.1
            //. Find the unique Category names from Product List

            //var uniqueCategories = ListGenerator.ProductList
            //                      .Select(p => p.Category)
            //                      .Distinct();
            //Console.WriteLine("Unique Categories");

            //foreach (var item in uniqueCategories)

            //        Console.WriteLine(item);

            #endregion

            #region Q.2
            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var UniqueFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Union(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //Console.WriteLine("Unique First Letters ");
            //foreach (var item in UniqueFirstLetters)
            //    Console.WriteLine(item);

            #endregion

            #region Q.3
            //3. Create one sequence that contains the common first letter from both product and customer names.

            //var CommonFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName[0])
            //    .Intersect(ListGenerator.CustomerList.Select(c => c.CustomerName[0]));

            //Console.WriteLine("Common First Letters : ");
            //foreach (var item in CommonFirstLetters)
            //    Console.WriteLine(item);


            #endregion

            #region Q.4
            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var ProductOnlyFirstLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName)
            //    .Except(ListGenerator.CustomerList.Select(c => c.CustomerName));

            //Console.WriteLine("Product Only First Letters ");
            //foreach (var Letters in ProductOnlyFirstLetters)
            //    Console.WriteLine(Letters);

            #endregion

            #region Q.5
            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var LasrThreeLetters = ListGenerator.ProductList
            //    .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //    .Concat(ListGenerator.CustomerList
            //    .Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));

            //Console.WriteLine("Last 3 Charachters OF NAmes ");
            //foreach (var item in LasrThreeLetters)

            //      Console.WriteLine(item);


            #endregion


            #endregion

            #region Quantifiers

            #region  Q.1
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //bool hasEi = words.Any(w => w.Contains("ei"));
            //Console.WriteLine($"Any Word Contain 'ei' ? {hasEi}");

            #endregion

            #region Q.2
            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var ProductsOnlyforCategories=ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any( p =>p.UnitsInStock==0));

            //foreach (var  group in ProductsOnlyforCategories)
            //{
            //    Console.WriteLine($"Category {group.Key}");
            //    foreach (var product in group)
            //        Console.WriteLine($" {product.ProductName} , {product.UnitsInStock} in stock ");
            //}

            #endregion

            #region Q.3
            //3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var ProductsOnlyCategories = ListGenerator.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var group in ProductsOnlyCategories)
            //{
            //    Console.WriteLine($"Category : {group.Key}");
            //    foreach (var product in group)
            //        Console.WriteLine($" {product.ProductName}  , {product.UnitsInStock} in Stock ");
            //}

            #endregion

            #endregion


            #region Grouping Operators

            #region Q.1

            //Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groups = numbers.GroupBy(n => n % 5);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"Numbers With A Reminder of  {group.Key} when dovoded by 5 :");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            #endregion

            #region Q.2
            //Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var wordGroup = words.GroupBy(w => w[0]);

            //foreach (var group in wordGroup)
            //{
            //    Console.WriteLine($"Words that starts with : {group.Key} : ");
            //    foreach (var word in group.Take(5))
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("....");
            //}


            #endregion

            #region Q.3
            //Consider this Array as an Input

            //string[]  Arr= { "from", "salt", "earn", " last", "near", "form" };

            //var anagramGroups = Arr
            //  .GroupBy(w => System.String.Concat(w.OrderBy(c => c))); // sort letters inside word
            //foreach (var  group in anagramGroups )
            //{
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("....");
            //}

            #endregion

            #endregion


        }
    }
}
