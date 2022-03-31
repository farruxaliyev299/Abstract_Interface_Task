using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenu
{
    internal class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;

        public Product(int no,string name,double price,int count)
        {
            if(no <= 0 || name == "" || name == " " || price <= 0)
            {
                Console.WriteLine("\nDaxil edilen melumatlar sehvdir!");
            }
            else
            {
                No = no;
                Name = name;
                Price = price;
            }
            Count = count;
        }
    }
}
