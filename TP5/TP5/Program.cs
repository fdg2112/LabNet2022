using System;
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
            Console.WriteLine("Ejercicio 12. Primer elemento de una lista de productos");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsByName();
            Console.WriteLine(query.First().ProductName);
            Console.ReadLine();
        }

        private static void Ejercicio10()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 10. Listado de productos ordenados por existentes en stock de mayor a menor");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsPerUnitInStock();
            foreach (var item in query) Console.WriteLine($"{item.ProductName} - En stock: {item.UnitsInStock}");
            Console.ReadLine();
        }

        private static void Ejercicio9()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 9. Listado de productos ordenados por nombre");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetProductsByName();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio8()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 8. Listado de 3 clientes de la Region WA");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetFromWaTop3();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }

        private static void Ejercicio7()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 7. Listado de nombres de clientes de la region WA con odenes posteriores al 1/1/1997");
            Console.WriteLine(Environment.NewLine);
            CustomersData.GetFromWaAnd1997();
            Console.ReadLine();
        }

        private static void Ejercicio6()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 6. Listado de nombres de clientes en mayusculas y minúsculas");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetNames();
            foreach (var item in query) Console.WriteLine($"{item.ContactName.ToUpper()}");
            foreach (var item in query) Console.WriteLine($"{item.ContactName.ToLower()}");
            Console.ReadLine();
        }

        private static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 5. Producto con ID 789");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetFirstWithId789();
            if (query.Count() == 0) Console.WriteLine("Null");
            else Console.WriteLine($"{query.First().ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4. Listado de clientes de la Region WA");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetFromWA();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }

        private static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3. Listado de productos con Stock y Precio Unitario mayor que 30");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetUnitPriceGreaterThan30();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2. Listado de productos con Stock 0");
            Console.WriteLine(Environment.NewLine);
            var query = ProductsData.GetStockZero();
            foreach (var item in query) Console.WriteLine($"{item.ProductName}");
            Console.ReadLine();
        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1. Listado de clientes");
            Console.WriteLine(Environment.NewLine);
            var query = CustomersData.GetAll();
            foreach (var item in query) Console.WriteLine($"{item.CompanyName} - {item.ContactName} - {item.Phone}");
            Console.ReadLine();
        }
    }
}
