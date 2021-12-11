using System;
using System.Linq;
using System.Collections.Generic;

namespace Take_Home_Assignment_Week_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                Console.Write("1. My scroll list \n2. Add scroll \n3. Search Scroll \n4. Remove scroll \n5. Exit program \nChoose what to do : ");
                int pilihanMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (pilihanMenu == 1)
                {
                    Console.WriteLine("Scroll to learn list : ");
                    for (int scrollList = 0; scrollList < scrolls.Count; scrollList++)
                        Console.WriteLine($"Scroll {scrollList + 1} : {scrolls[scrollList]}");
                    Console.Write("\n");
                }
                else if (pilihanMenu == 2)
                {
                    Console.Write("How many scroll to add : \n==> ");
                    int banyakScroll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of queue? \n==> ");
                    int urutanScroll = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Clear();
                    if (urutanScroll < 1)
                        urutanScroll = 0;
                    if (urutanScroll > scrolls.Count)
                        urutanScroll = scrolls.Count;
                    for (int penambahanScroll = 0; penambahanScroll < banyakScroll; penambahanScroll++)
                    {
                        Console.Write($"Scroll {penambahanScroll + 1} name : ");
                        scrolls.Insert(urutanScroll + penambahanScroll, Console.ReadLine());
                    }
                    Console.Write("\n");
                }
                else if (pilihanMenu == 3)
                {
                    Console.Write("Insert scroll name : \n==> ");
                    var namaScroll = Console.ReadLine().ToLower();
                    int counter = 0;
                    for (int mencariScroll =0; mencariScroll < scrolls.Count; mencariScroll++)
                    {
                        if (namaScroll == scrolls[mencariScroll].ToLower())
                        {
                            Console.WriteLine($"Book found. Queue number : {mencariScroll + 1}\n");
                            counter++;
                        }
                    }
                    if (counter == 0)
                        Console.WriteLine("Book not found\n");
                }
                else if (pilihanMenu == 4)
                {
                    Console.Write("Remove from list by scroll name? Y/N : \n==> ");
                    var menghapusList = Console.ReadLine().ToLower();
                    while (menghapusList != "y" && menghapusList != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again!!!\n");
                        Console.WriteLine("Remove from list by scroll name? Y/N : \n==> ");
                        menghapusList = Console.ReadLine().ToLower();
                    }
                    if (menghapusList == "y")
                    {
                        Console.Write("\nInput scroll name : \n==> ");
                        var menghapusNamaList = Console.ReadLine().ToLower();
                        int counter = 0;
                        for (int menghapusNamaScroll = 0; menghapusNamaScroll < scrolls.Count; menghapusNamaScroll++)
                        {
                            if (menghapusNamaList == scrolls[menghapusNamaScroll].ToLower())
                            {
                                scrolls.RemoveAt(menghapusNamaScroll);
                                Console.WriteLine("Book Removed!\n");
                                counter++;
                            }
                        }
                        if (counter == 0)
                            Console.WriteLine("Book not found\n");
                    }
                    else if (menghapusList == "n")
                    {
                        Console.Write("Input scroll queue : \n==> ");
                        int menghapusUrutanScroll = Convert.ToInt32(Console.ReadLine());
                        while (menghapusUrutanScroll > scrolls.Count && menghapusUrutanScroll < scrolls.Count)
                        {
                            Console.Write("Queue not found. Insert scroll queue : ");
                            menghapusUrutanScroll = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        scrolls.RemoveAt(menghapusUrutanScroll - 1);
                        Console.WriteLine("Book Removed!\n");
                    }
                }
                else if (pilihanMenu == 5)
                    System.Environment.Exit(0);
            }
        }
    }
}