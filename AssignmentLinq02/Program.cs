using Day01LinQ;

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


        }
    }
}
