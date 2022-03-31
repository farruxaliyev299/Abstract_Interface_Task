using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenu
{
    internal class Book:Product
    {
        public string Genre;

        public Book(int no,string name,double price,int count,string genre):base(no,name,price,count)
        {
            if (genre == "" || genre == " ")
            {
                Console.WriteLine("Melumatlar yanlis daxil edilib");
            }
            else
            {
                Genre = genre;
            }
        }

        public void ShowAllBooks()
        {
            Console.WriteLine($"\n\nBook {No}:\nName: {Name}\nPrice: {Price}\nCount: {Count}\nGenre: {Genre}\n\n");
        }

        
    }
}
