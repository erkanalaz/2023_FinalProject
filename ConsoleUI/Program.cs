using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetProductsByCatId();

            GetCategoryById();
        }

        private static void GetCategoryById()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetById(1))
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void GetProductsByCatId()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.CategoryName+" / "+item.ProductName);
            }

            Console.WriteLine("-----------------------------------------");
        }
    }
}
