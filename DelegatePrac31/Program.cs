﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePrac31
{
    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return this.Name + " : " + this.Price;
            }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 500 },
                new Product() { Name = "사과", Price = 700 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "배추", Price = 600 },
                new Product() { Name = "상추", Price = 300 },
            };
            // 정렬
            // 1. Delegator 를 활용한 구현 방법
            //products.Sort(SortWithPrice);

            // 2. 무명 Delegator를 활용한 구현 방법
            //products.Sort(delegate (Product x, Product y) { 
            //    return x.Price.CompareTo(y.Price);
            //});

            // 3. 람다를 활용한 구현 방법1 
            //products.Sort((x, y) => { 
            //    return x.Price.CompareTo(y.Price); 
            //});

            // 3. 람다를 활용한 구현 방법2
            products.Sort((x, y) => x.Price.CompareTo(y.Price));

            products.ForEach(p => Console.WriteLine(p));


            //출력
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Name + " : " + item.Price);
            //}
        }

        private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}