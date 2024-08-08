using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static Demo.ListGenerator;
//using System.Text.RegularExpressions;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Aggregate Operators [ Count , Sum , Min , Max , Average ]

            //var Result = ProductsList.Count();

            //var Result = ProductsList.Min();
            //var Result = ProductsList.Max(); 


            //Overload
            //var Result = ProductsList.Max(P => P.ProductName.Length);
            //Result = ProductsList.Min(P => P.ProductName.Length);

            //Hybrid syntax 
            // Get the product that have the minimum name length

            //var MinLength = ProductsList.Min(P => P.ProductName.Length);
            //var Result = (from P in ProductsList
            //              where P.ProductName.Length == MinLength
            //              select P).FirstOrDefault();
            //Console.WriteLine(Result?.ProductName ?? "Mohamed");

            //var Result = ProductsList.Sum(P => P.UnitPrice);
            //Result = ProductsList.Average(P => P.UnitPrice);

            // Aggregate

            //string[] Names = { "Moahmed", "Adel", "Sara", "Adel", "Nourhan", "Tareq" };
            //var Result = Names.Aggregate((S1, S2) => $"{S1} {S2}");

            #endregion

            #region Casting [Conversion] Operators - Immediate Execution
            // 1- ToList
            //List<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToList();

            //2- To Array

            //Product[] Result = ProductsList.Where(P => P.UnitsInStock == 0).ToArray();

            //3- To Dictionary
            //Dictionary<long, Product> Result = ProductsList.Where(P => P.UnitsInStock == 0)
            //    .ToDictionary(P => P.ProductID);

            //Dictionary<long, string> Result = ProductsList.Where(P => P.UnitsInStock == 0)
            //    .ToDictionary(P => P.ProductID, P => P.ProductName);

            //4- To HashSet

            //HashSet<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //5- OfType
            //ArrayList Obj = new ArrayList() 
            //{
            //    "Omer",
            //    "Mohamed",
            //    "Nouwara",
            //    1,2,3
            //};
            //var Result = Obj.OfType<string>();
            #endregion

            #region Generation Operators - Deferred Execution [Range - Repeat - Empty]

            //var Result = Enumerable.Range(0, 100);
            //Result = Enumerable.Repeat(2, 100);
            //var Result = Enumerable.Empty<Product>();

            #endregion

            #region Set Operators [Union Family] - Deferred Execution

            var Seq01 = Enumerable.Range(0, 100);  // 0 -> 99
            var Seq02 = Enumerable.Range(50, 100); // 50 -> 149

            //var Result = Seq01.Union(Seq02); // 0 - 149 Without Dublication

            //Result = Seq01.Concat(Seq02); // 0 -> 99 + 50 -> 149

            //Result = Seq01.Intersect(Seq02); // 50 -> 99

            //Result = Seq01.Except(Seq02); // 0 -> 49

            //Result = Seq01.Concat(Seq02).Distinct(); // as Union 0 - 149 Without Dublication

            #endregion

            #region Quantifier Operator - Return boolean [Any - All - SequanceEqual]
            //var Result = ProductsList.Any();
            //var Result = ProductsList.Any(P => P.UnitsInStock == 0);

            //var Result = ProductsList.All(P => P.UnitsInStock == 0);

            //var Result = Seq01.SequenceEqual(Seq02);
            #endregion

            #region Zipping Operator [Zip]

            int[] Numbers  = Enumerable.Range(0, 10).ToArray();
            string[] Names = { "Omer", "Ahmed", "Ali" };


            //var Result = Numbers.Zip(Names);

            //var Result = Numbers.Zip(Names, (Number, Name) => new { ind = Number, Name = Name });
            #endregion

            #region Grouping Operators

            #region Get Products Grouped by Category

            //Fluent
            //var Result = ProductsList.GroupBy(P => P.Category);

            //Query
            //var Result = from P in ProductsList
            //             group P by P.Category;

            #endregion

            #region Get Products in Stock Grouped by Category

            // fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category);

            //Query 
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category;

            #endregion

            #region Get Products in Stock Grouped by Category That Contains More Than 10 Product

            // Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category).Where(C => C.Count() > 10);

            // Query
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into category
            //             where category.Count() > 10
            //             select category;

            #endregion

            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            //Fluent
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).GroupBy( P => P.Category).Where(C => C.Count() > 10).Select(C => new {Name = C.Key, NumberOfProduct = C.Count()});

            //Query
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new
            //             {
            //                 Name = Category.Key,
            //                 NumOfProduct = Category.Count(),
            //             };
            #endregion

            #endregion

            #region Partitioning Operators

            //var Result = ProductsList.Take(10); // Take 10 Element from the First

            //Result = ProductsList.Where( P => P.UnitsInStock > 0).TakeLast(10);

            //Result = ProductsList.Skip(10); // Skip First 10 Element 

            //Result = ProductsList.SkipLast(10); // Skip Last 10 Element 

            //           //[ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ]    => I    
            //int[] Nums = { 1, 6, 9, 3, 6, 2, 7, 4, 0, 8 };// => N

            //var Result = Nums.TakeWhile((N, I) => N > I); // Take Element While Conditon Is true Till Element that do Not match condition stop.

            //Result = Nums.SkipWhile((N, I) => N > I); // Skip Elements  while Condition is true Till Element That do not Match Condition
            #endregion

            #region Let and Into 

            //List<string> Names02 = new List<string>() { "Omer", "Ahmed", "Adel", "Sara"};

            //    //var Result = from N in Names02
            //    //             select Regex.Replace(N, "[AEIOUaeiou]", string.Empty)
            //    //             into NoVowelName
            //    //             where NoVowelName.Length > 1
            //    //             select NoVowelName;

            //var Result = from N in Names02
            //             let NoVowelName = Regex.Replace(N, "[AEIOUaeiou]", string.Empty)
            //             where NoVowelName.Length > 1
            //             select NoVowelName;

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
