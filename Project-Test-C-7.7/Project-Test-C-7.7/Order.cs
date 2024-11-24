using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    internal class Order<T>
    {
        private List<Product> products;
        private Delivery delivery;
        private T number;

        public static Order<T> operator +(Order<T> First, Order<T> Second)
        { 
            Order<T> newOrder = new Order<T>(First.delivery.Address, First.Number);
            List<Product> newOrderProducts = new List<Product>();
            foreach (var product in First.Products)
            {
                if (!newOrderProducts.Contains(product))
                    newOrderProducts.Add(product);
            }

            foreach (var product in Second.Products)
            {
                if (!newOrderProducts.Contains(product))
                    newOrderProducts.Add(product);
            }

            DateTime RegistrationDate = First.delivery.RegistrationDate;
            if (StaticFunctions.CompareDateTime(Second.delivery.RegistrationDate, First.delivery.RegistrationDate))
                RegistrationDate = Second.delivery.RegistrationDate;

            DateTime ReceiptDate = First.delivery.ReceiptDate;
            if (StaticFunctions.CompareDateTime(Second.delivery.ReceiptDate, First.delivery.ReceiptDate))
                ReceiptDate = Second.delivery.ReceiptDate;

            newOrder.Products = newOrderProducts;
            return newOrder;
        }

        public Order(string Address, T number)
        {
            products = new List<Product>();
            this.number = number;   
            this.delivery = new HomeDelivery(Address, DateTime.Now, DateTime.Now);
        }

        public Order(string Address, T number, StaticFunctions.TypeDelivery Td, string ShopName, int ShelfLife)
        {
            products = new List<Product>();
            this.number = number;
            switch (Td)
            {
                case StaticFunctions.TypeDelivery.tdShop:
                    this.delivery = new ShopDelivery(ShopName, ShelfLife, Address);
                    break;
                case StaticFunctions.TypeDelivery.tdPickPoint:
                    this.delivery = new PickPointDelivery(ShopName, ShelfLife, Address);
                    break;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Номер заказа: {this.number}");
            Console.WriteLine($"Адрес доставки: {this.delivery.Address}");
            Console.WriteLine($"Список товаров: ");
            foreach (var good in products)
                Console.WriteLine(good.Name);
        }

        public Product this[int index]
        {
            get
            {
                if (products != null && products.Count > 0)
                    return products[index];
                else
                    return null;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public T Number
        {
            get
            { 
                return number; 
            }
            set
            { 
                number = value; 
            }
        }

        public void AddProduct(string NameProduct, double Weight)
        {
            products.Add(new Product(NameProduct, Weight));
        }

        public void RemoveProduct(string NameProduct) 
        { 
            int index = FindIndexProduct(NameProduct);    
            if (index != -1)
                products.Remove(products[index]);
        }

        public void RemoveProduct(int IndexProduct)
        {
            products.Remove(products[IndexProduct]);
        }

        protected int FindIndexProduct(string NameProduct) 
        {
            int index = -1;
            for (int i = 0; i < products.Count - 1; i++) 
            {
                if (products[i].Name == NameProduct)
                    index = i;

                if (index != -1)
                    break;
            }
            return index;
        }

        protected Product FindProduct(string NameProduct)
        {
            Product findProduct = null;
            foreach (Product product in products)
            {
                if (product.Name == NameProduct)
                    findProduct = product;
            }
            return findProduct;
        }

        protected void ChangeProduct(Product product, string ChangeProductName)
        {
            for (int i = 0; i < products.Count - 1; i++) 
            {
                if (products[i].Name == ChangeProductName)
                {
                    products.RemoveAt(i);
                    break;
                }        
            }
            Products.Add(product);
        }
    }
}
