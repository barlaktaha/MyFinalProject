﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest(); // CategoryTest(); // DetailTest();


        }

        //private static void DetailTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine("Ürün Adı: " + product.ProductName + "  Kategori Adı: " + product.CategoryName + "  Stok Adedi: " + product.UnitsInStock);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}S

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetProductDetails().Data)
        //    {
        //        Console.WriteLine("Ürün Adı: "+ product.ProductName + "  Kategori Adı: " + product.CategoryName + "  Stok Adedi: " + product.UnitsInStock);
        //    }
        //}
    }
}
