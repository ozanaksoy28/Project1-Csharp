using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TelefonRehberi
{
    public static class Tasks
    {
        public static void AddPerson(List<Person> personList)
        {
            Console.WriteLine("Lütfen isim giriniz              :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz           :");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz  :");
            string pNumber = Console.ReadLine();
            personList.Add(new Person(name,surname,pNumber));
            Console.WriteLine("Kişi eklendi... {0} {1} {2} \n\n\n", name, surname, pNumber);
        }
        public static void RemovePerson(List<Person> personList)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string keyWord = Console.ReadLine();
            int index = Search(keyWord, personList);
            if (index >= 0)
            {
                Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", personList[index].Name, personList[index].Surname);
                char input = Convert.ToChar(Console.ReadLine());
                if(input == 'y')
                {
                    try
                    {
                        personList.RemoveAt(index);
                        Console.WriteLine("Kişi Silindi... \n\n\n");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Hata.. " + e.Message);
                    }
                    
                }

            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                byte selection = Convert.ToByte(Console.ReadLine());
                if (selection == 2)
                {
                    RemovePerson(personList);
                }else
                {
                    Console.WriteLine("Silme sonlandırıldı. \n\n\n");
                }
                
            }
            
        }
        public static void UpdatePerson(List<Person> personList)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string keyWord = Console.ReadLine();
            int index = Search(keyWord, personList);
            if (index >= 0)
            {
                Console.WriteLine("Kişinin ismi({0})              :", personList[index].Name);
                string name = Console.ReadLine();
                Console.WriteLine("Kişinin soyismi({0})           :", personList[index].Surname);
                string surname = Console.ReadLine();
                Console.WriteLine("Kişinin telefon numarası({0})  :", personList[index].PNumber);
                string pNumber = Console.ReadLine();
                personList[index].Name = name;
                personList[index].Surname = surname;
                personList[index].PNumber = pNumber;
                Console.WriteLine("Kişi Güncellendi. {0} {1} {2}\n\n\n", personList[index].Name, personList[index].Surname, personList[index].PNumber);
            }
        }
        public static void ListPerson(List<Person> personList)
        {
            Console.WriteLine("----Telefon Rehberi----");
            Console.WriteLine("***********************");
            foreach(Person person in personList)
            {
                Console.WriteLine("İsim Soyisim: {0} {1}", person.Name, person.Surname);
                Console.WriteLine("Telefon numarası: {0}",person.PNumber);
                Console.WriteLine("----");
            }
            Console.WriteLine("\n\n\n");
        }
        public static int Search(string keyword,List<Person> personList)
        {
            
            foreach(Person person in personList)
            {
                if (person.Name.ToLower() == keyword.ToLower() || person.Surname.ToLower() == keyword.ToLower())
                {
                    return personList.IndexOf(person);
                }
            }
            return -1;
        }
        public static void FilteredPerson(List<Person> personList)
        {

            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)\n\n");
            byte selection = Convert.ToByte(Console.ReadLine());
            if(selection == 1)
            {
                Console.WriteLine("İsim veya Soyisim girin");
                string filterName = Console.ReadLine();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (Person person in personList)
                {
                    if (person.Name.ToLower()==filterName.ToLower() || person.Surname.ToLower() == filterName.ToLower())
                    {

                        Console.WriteLine("isim: {0}",person.Name);
                        Console.WriteLine("Soyisim: {0}",person.Surname);
                        Console.WriteLine("Telefon Numarası: {0}",person.PNumber);
                        Console.WriteLine("----------");
                    }
                }
            }else if(selection == 2)
            {
                Console.WriteLine("Telefon numarası girin: ");
                string filterNumber = Console.ReadLine();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (Person person in personList)
                {
                    if(person.PNumber == filterNumber)
                    {

                        Console.WriteLine("isim: {0}", person.Name);
                        Console.WriteLine("Soyisim: {0}", person.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", person.PNumber);
                        Console.WriteLine("----------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçerli sayı girin!!\n\n");
                FilteredPerson(personList);
            }
        }
    }
}
