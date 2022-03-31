using System;

namespace BookMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitablarin sayini daxil et:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("No , Name , Price , Count , Genre:");

            Book[] books = new Book[length];
            for (int i = 0; i < length; i++)
            {
                books[i] = CreateBook();
                Console.WriteLine("\n\n");
            }

            bool check = false;
            while (!check)
            {
                Console.WriteLine("\n\n1.Kitablari qiymete gore filterle\n2.Butun kitablari goster\n0.Programi bagla");

                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    check = true;
                }
                else if (num == 1)
                {
                    Console.WriteLine("\nMinimum Deyer:");
                    double minPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nMaximum Deyer:");
                    double maxPrice = double.Parse(Console.ReadLine());

                    for (int i = 0; i < length; i++)
                    {
                        if(books[i].Price >= minPrice && books[i].Price <= maxPrice)
                        {
                            books[i].ShowAllBooks();
                        }
                    }
                }
                else if (num == 2)
                {
                    for (int i = 0; i < length; i++)
                    {
                        books[i].ShowAllBooks();
                    }
                }
                else
                {
                    Console.WriteLine("Menu contenti duzgun daxil edilmedi!");
                }

            }

        }

        static Book CreateBook()
        {
            
            Book book = new Book(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine());

            return book;
        }

        
    }
}
