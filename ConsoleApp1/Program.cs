
using ConsoleApp1.TelefonRehberi;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>();
            personList.Add(new Person("Ahmet", "Yılmaz", "1231231"));
            personList.Add(new Person("Mehmet", "Sert", "456456456"));
            personList.Add(new Person("Ayşe", "Bulut", "654654654"));
            personList.Add(new Person("Volkan", "Demirel", "36936369"));
            personList.Add(new Person("Yasin", "Aakrsu", "159159159"));
            MainMenu.Start(personList);
        }
        
    }
    public static class MainMenu
    {
        public static void Start(List<Person> personList)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Tasks.AddPerson(personList);
                    break;
                case 2:
                    Tasks.RemovePerson(personList);
                    break;
                case 3:
                    Tasks.UpdatePerson(personList);
                    break;
                case 4:
                    Tasks.ListPerson(personList);
                    break;
                case 5:
                    Tasks.FilteredPerson(personList);
                    break;
            }
            Start(personList);
        }
    }
}
