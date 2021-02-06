using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductCalismasi();

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
            Console.WriteLine("---------------------");
            CategoryManager categoryManager1 = new CategoryManager(new EfCategoryDal());
            var category1 = categoryManager1.GetById(3);
            Console.WriteLine(category1.CategoryName);




        }

        private static void ProductCalismasi()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(10, 100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
