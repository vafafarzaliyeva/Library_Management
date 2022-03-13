using LibraryProject.Enums;
using LibraryProject.Interfaces;
using LibraryProject.Models;
using LibraryProject.Services;
using System;

namespace LibraryProject
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("------------ WELCOME------------\n");
            Service serv = new Service();
            do
            {
                Console.WriteLine("1. Yeni kitab elave edin");
                Console.WriteLine("2. Kitab adi daxil edin");
                Console.WriteLine("3. Axtaris edin");
                Console.WriteLine("4. Yazicinin adini ve janri daxil edin");
                Console.WriteLine("5. Cixis et\n\n");
                Console.WriteLine("Secim edin");

                string choose = Console.ReadLine();
                int chooseNum;

                while (!int.TryParse(choose, out chooseNum) || chooseNum < 1 || chooseNum > 5)
                {
                    Console.WriteLine("Duzgun secim edin");
                    choose = Console.ReadLine();
                }

                Console.Clear();

                switch (chooseNum)
                {
                    case 1:
                        Add(ref serv);
                        break;
                    case 2:
                        ShowInfo(ref serv);
                        break;
                    case 3:
                        Search(ref serv);
                        break;
                    case 4:
                        Filter(ref serv);
                        break;
                    case 5:
                        return;
                   


                }

            } while (true);
        }

        static void Add(ref Service serv)
        {

            Console.WriteLine("Janrin novunu secin:");
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }

            string genretypestr = Console.ReadLine();
            int genretypeNum;

            while (!int.TryParse(genretypestr, out genretypeNum) || genretypeNum < 1 || genretypeNum > 5)
            {
                Console.WriteLine("Duzgun Secim Edin:");
                genretypestr = Console.ReadLine();
            }

            Genre genreType = (Genre)genretypeNum;

            Console.WriteLine("Kitab adini daxil edin:");
            string name = Console.ReadLine();
        

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Duzgun Secim Edin:");
                name = Console.ReadLine();
            }
            Console.WriteLine("Yazici adini daxil edin:");
            string nameauthor = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(nameauthor))
            {
                Console.WriteLine("Duzgun Secim Edin:");
                nameauthor = Console.ReadLine();
            }
            Console.WriteLine("Sehife sayini daxil edin:");
            string pageStr = Console.ReadLine();
            int pageNum;
            
            while (!int.TryParse(pageStr, out pageNum))
            {
                Console.WriteLine("Duzgun daxil edin");
                pageStr = Console.ReadLine();
            }

            Book book = new Book(name,nameauthor,genreType,pageNum);

            serv.Add(book);
        }

        static void ShowInfo(ref Service serv)
        {
            Console.WriteLine("Kitab adi daxil edin:");
            string nameofbook = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(nameofbook))
            {
                Console.WriteLine("Duzgun Secim Edin:");
                nameofbook = Console.ReadLine();
            }

            serv.ShowInfo(nameofbook);
            foreach (Book item in serv.Books)
            {
                Console.WriteLine(item);
                Console.WriteLine("=======================");
            }
        }

        static void Search(ref Service serv)
        {
            Console.WriteLine("Axtaris edin:");
            string search = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(search))
            {
                Console.WriteLine("Duzgun Secim Edin:");
                search = Console.ReadLine();
            }

            serv.ShowInfo(search);
            foreach (Book item in serv.Books)
            {
                Console.WriteLine(item);
                Console.WriteLine("=======================");
            }
        }
        static void Filter(ref Service serv)
        {
            Console.WriteLine("Janrin novunu secin:");
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }

            string genretypestr = Console.ReadLine();
            int genretypeNum;

            while (!int.TryParse(genretypestr, out genretypeNum) || genretypeNum < 1 || genretypeNum > 5)
            {
                Console.WriteLine("Duzgun Secim Edin:");
                genretypestr = Console.ReadLine();
            }

            Genre genreType = (Genre)genretypeNum;


            Console.WriteLine("Yazicinin adini daxil edin:");
            string author = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Duzgun Secim Edin:");
                author = Console.ReadLine();
            }

            serv.Filter(author,genreType);

            foreach (Book item in serv.Books)
            {
                Console.WriteLine(item);
                Console.WriteLine("=======================");
            }
            
        }



    }
}

