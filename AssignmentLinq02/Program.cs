using static Day01LinQ.ListGenerator;


namespace AssignmentLinq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region casting operators - defferd excution
            // List<Product> Result = ProductsList.Where(p => p.UnitsInStock == 0).ToList(); // casting to list
            //foreach (Product Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            //Product[] Result = ProductsList.Where(p => p.UnitsInStock == 0).ToArray(); // casting to array
            //foreach (Product Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            //Dictionary<long, Product> Result = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                               .ToDictionary(p => p.ProductID);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"key = {item.Key} , value = {item.Value}");
            //}

            //Dictionary<long, string> Result = ProductsList.Where(p => p.UnitsInStock == 0)
            //                                               .ToDictionary(p => p.ProductID, p => p.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"key = {item.Key} , value = {item.Value}");
            //}


            //HashSet<Product> Result = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet(); // casting to list
            //foreach (Product Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            //  ArrayList obj = new ArrayList()
            //  {
            //      "Youssef",
            //          "Omar",
            //          1,
            //          3
            //  };
            //  var Result =obj.OfType<int>(); //string the same behavior
            //  foreach (var Product in Result)
            //  {
            //      Console.WriteLine(Product);
            //  }

            #endregion
            #region Generation Operators Deffered Execution 
            // Valid Only With Fluent Syntax only 
            // The Only Way To Call Them Is As Static Methods From Class Enumerable 
            //var Result = Enumerable. Range(0, 100); // 8..99 
            //Result = Enumerable. Repeat(2, 100); 
            //// Return IEnumerable Of 100 Element each One = 2 
            //var Result Enumerable.Repeat(new Product(), 100);
            // Return IEnumerable Of 100 Product 
            // var array Product Enumerable. Empty<Product>().ToArray();
            //Product[] Products = new Product[0];
            // Both Will Generate an Empty Array of Products
            //var List Enumerable.Empty<Product>().ToList();
            //  List<Product> Products02 = new List<Product>();
            // Both Will Generate An Empty List Of Product 
            // foreach (var item in Result)
            // {
            //     Console.Write($"{item} ");
            // }
            #endregion
            #region set operators Deffered Execution 
            //   var Seq01= Enumerable.Range(0, 100); // 0..99 

            //  var Seq02 =Enumerable.Range(50, 100); // 50..149 
            //  var Result = Seq01. Union (Seq02); //0..149 ->  Remove Duplication
            // var Result = Seq01.Concat(Seq02); //0..49 + 50..149
            // Result = Result.Distinct(); // remove duplication
            //   Result = Seq01.Intersect(Seq02); //50..99
            // var Result = Seq01.Except(Seq02); //0 ..49

            //  Console.WriteLine("\n===================SEQ01================");
            //  foreach (var item in Seq01) Console.Write($"{item}, ");
            //  Console.WriteLine("\n===================SEQ02================");
            //  foreach (var item in Seq02)
            //      Console.Write($"{item} ");
            //  Console.WriteLine("\n===================concat================");
            //  foreach (var item in Result)
            //  {
            //      Console.Write($"{item}, ");
            //  } 
            #endregion
            #region Quentifier Operators Return Boolean 
            // var Result = ProductsList.Any();
            // // If Sequence Contains At Least One Element => True 
            // Result = ProductsList.Any(P => P.UnitsInStock == 0);
            // // If Sequence Contains At Least One Element Match Condition => True 
            // Result = ProductsList.Any(P => P.UnitsInStock > 1000); // False 
            // Result = ProductsList.All(P => P.UnitsInStock == 1);
            // // If All Elements in Sequence Match Condition Return True 
            // var Seq01= Enumerable.Range(0, 100); // 0..99 
            // var Seq02= Enumerable.Range(0, 100); // 0..99 
            // Result = Seq01.SequenceEqual(Seq02);
            // Console.WriteLine(Result);
            #endregion

        }
    }
}
