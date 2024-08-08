using System.Diagnostics;
using System.Linq;
using static Assignment.ListGenerator;
using System.IO;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggregate Operators

            #region Q1 Get the total units in stock for each product category.

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category).Select(C => new {Name = C.Key, Units = C.Count() });

            #endregion

            #region Q2 Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Min(P => P.UnitPrice));

            #endregion

            #region Q3 Get the products with the cheapest price in each category (Use Let) ???

            //var Result = from P in ProductsList
            //             group P by P.Category into C
            //             let 


            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Min());

            //ProductID: 24,ProductName: Guaraná Fantástica, CategoryBeverages, UnitPrice:4.5000,UnitsInStock: 20
            //ProductID: 3,ProductName: Aniseed Syrup, CategoryCondiments, UnitPrice:10.0000,UnitsInStock: 13
            //ProductID: 74,ProductName: Longlife Tofu, CategoryProduce, UnitPrice:10.0000,UnitsInStock: 4
            //ProductID: 54,ProductName: Tourtière,CategoryMeat / Poultry,UnitPrice: 7.4500,UnitsInStock: 21
            //ProductID: 13,ProductName: Konbu,CategorySeafood,UnitPrice: 6.0000,UnitsInStock: 24
            //ProductID: 33,ProductName: Geitost,CategoryDairy Products, UnitPrice:2.5000,UnitsInStock: 112
            //ProductID: 19,ProductName: Teatime Chocolate Biscuits,CategoryConfections,UnitPrice: 9.2000,UnitsInStock: 25
            //ProductID: 52,ProductName: Filo Mix, CategoryGrains/ Cereals,UnitPrice: 7.0000,UnitsInStock: 38

            #endregion

            #region Q4 Get the most expensive price among each category's products

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Max(P => P.UnitPrice));

            #endregion

            #region Q5 Get the products with the most expensive price in each category.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Max());

            #endregion

            #region Q6 Get the average price of each category's products.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Average(P => P.UnitPrice));

            #endregion

            #endregion

            #region Set Operators

            #region Q1 Find the unique Category names from Product List

            //var Result = ProductsList.Select(P => P.Category).Distinct();

            #endregion

            #region Q2 Produce a Sequence containing the unique first letter from both product and customer names.


            //var Result = ProductsList.Select(P => P.ProductName[0]).Union(CustomersList.Select(C => C.CustomerName[0]));

            #endregion

            #region Q3 Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));

            #endregion

            #region Q4 Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));

            #endregion

            #region Q5 Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var ProductNameChars = ProductsList.Select(P => P.ProductName.Substring(P.ProductName.Length - 3));
            //var CustomerNameChars = CustomersList.Select(C => C.CustomerName.Substring(C.CustomerName.Length - 3));

            //var Result = ProductNameChars.Concat(CustomerNameChars);

            #endregion

            #endregion

            #region Partitioning Operators

            #region Q1 Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders);

            #endregion

            #region Q2 Get all but the first 2 orders from customers in Washington.????

            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Take(2).Concat();

            #endregion

            #region Q3 Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N > I);

            #endregion

            #region Q4 Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(N => N % 3 != 0);

            #endregion

            #region Q5 Get the elements of the array starting from the first element less than its position.
            ////              [ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ]
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((N, I) => N > I);

            #endregion

            #endregion

            #region Quantifiers Operators

            #region Q1 Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'

            //List<string> DictionaryEnglish = new List<string>();
            //StreamReader reader;
            //try
            //{
            //    reader = new StreamReader("dictionary_english.txt");
            //    DictionaryEnglish.Add(reader.ReadLine());

            //    while (reader.ReadLine() != null)
            //    {
            //        DictionaryEnglish.Add(reader.ReadLine());
            //        //Console.WriteLine(reader.ReadLine());
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            //var Result = DictionaryEnglish.Any(W => W.Contains("ei"));
            #endregion

            #region Q2  Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = ProductsList.GroupBy(P => P.Category).Where(C => C.Any(P => P.UnitsInStock == 0));

            #endregion

            #region Q3 Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = ProductsList.GroupBy(P => P.Category).Where(C => C.All(P => P.UnitsInStock > 0));

            #endregion

            #endregion

            #region Grouping Operators

            #region Q1 Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(N => N % 5);

            //foreach (var remainder in Result)
            //{
            //    Console.WriteLine($"Numbers with a remainder {remainder.Key} when divided by 5:");
            //    foreach (var N in remainder)
            //    {
            //        Console.WriteLine(N);
            //    }
            //}

            #endregion

            #region Q2 Uses group by to partition a list of words by their first letter Use dictionary_english.txt for Input

            //List<string> DictionaryEnglish = new List<string>();
            //StreamReader reader;
            //try
            //{
            //    reader = new StreamReader("dictionary_english.txt");
            //    DictionaryEnglish.Add(reader.ReadLine());

            //    while (reader.ReadLine() != null)
            //    {
            //        DictionaryEnglish.Add(reader.ReadLine());
            //        //Console.WriteLine(reader.ReadLine());
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            //var Result = DictionaryEnglish.GroupBy(W => W[0]);

            //foreach (var Letter in Result)
            //{
            //    Console.WriteLine($"======{Letter.Key}======");
            //    foreach (var W in Letter)
            //    {
            //        Console.WriteLine(W);
            //    }
            //}

            #endregion

            #region Q3 Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            

            #endregion

            #endregion

            //Console.WriteLine(Result);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var P in category)
            //    {
            //        Console.WriteLine($"  {P.ProductName}");
            //    }
            //}
        }
    }
}
