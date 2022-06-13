﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Data;

namespace TP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
            Ejercicio12();

        }

        private static void Ejercicio12()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 12. Query para devolver el primer elemento de una lista de productos");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsByName();
            Console.WriteLine(query.First().ProductName);
            Console.ReadLine();
        }

        private static void Ejercicio10()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsPerUnitInStock();
            foreach (var item in query) Console.WriteLine($"{item.ProductName} - En stock: {item.UnitsInStock}");
            Console.ReadLine();
        }

        private static void Ejercicio9()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 9. Query para devolver lista de productos ordenados por nombre");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsByName();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio8()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 8. Query para devolver los primeros 3 Customers de la  Región WA");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetFromWaTop3();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }

        private static void Ejercicio7()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997");
            Console.WriteLine(Environment.NewLine);
            CustomersData.GetFromWaAnd1997();
            Console.ReadLine();
        }

        private static void Ejercicio6()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetNames();
            foreach (var item in query) Console.WriteLine($"{item.ContactName.ToUpper()}");
            foreach (var item in query) Console.WriteLine($"{item.ContactName.ToLower()}");
            Console.ReadLine();
        }

        private static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetFirstWithId789();
            if (query.Count() == 0) Console.WriteLine("No se encontró");
            else Console.WriteLine($"{query.First().ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4. Query para devolver todos los customers de la Región WA");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetFromWA();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }

        private static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetUnitPriceGreaterThan3();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2. Query para devolver todos los productos sin stock");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetStockZero();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1. Query para devolver objeto customer");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetAll();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }
    }
}