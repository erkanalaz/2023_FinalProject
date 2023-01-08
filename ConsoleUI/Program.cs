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
            GetAll();

            //GetProductDetails();

            //GetCategoryById();
        }

        private static void GetCategoryById()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetById(1))
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void GetProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CategoryName + " / " + item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            Console.WriteLine("-----------------------------------------");
        }


        private static void GetAll()
        {
            ProductManager productManager=new ProductManager(new EfProductDal());

            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);   
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
