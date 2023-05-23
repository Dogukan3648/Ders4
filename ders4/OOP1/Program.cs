namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.categoryId = 2;
            product1.productName = "Masa";
            product1.unitPrice = 500;
            product1.unitInStock = 3;


            Product product2 = new Product { Id =2,categoryId = 5,unitInStock = 5,productName = "Kalem",unitPrice =35};


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.productName);

        }   


    }
}