using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    internal class PhoneBookList
    {
        public static List<PhoneBookSabitler> Kisiler = new List<PhoneBookSabitler>();

        public static void CreatePhoneBook()
        {
            Kisiler.Add(new PhoneBookSabitler(){ FirstName = "Asım", LastName = "Sezer", PhoneNumber = "02125252520"});
            Kisiler.Add(new PhoneBookSabitler(){ FirstName = "Oğuzhan", LastName = "Kömürcü", PhoneNumber = "02125252521"});
            Kisiler.Add(new PhoneBookSabitler(){ FirstName = "Mertcan", LastName = "Uygun", PhoneNumber = "02125252522"});
            Kisiler.Add(new PhoneBookSabitler(){ FirstName = "Ceyhun", LastName = "Yılmaz", PhoneNumber = "02125252523"});
            Kisiler.Add(new PhoneBookSabitler(){ FirstName = "Ersin", LastName = "Aslan", PhoneNumber = "02125252524"});
        }

        public static void PhoneNumberAdd()
        {
            Console.Write("Lütfen isim giriniz             :");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string lastName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            string phoneNumber = Console.ReadLine();

            Kisiler.Add(new PhoneBookSabitler() { FirstName = name, LastName = lastName, PhoneNumber = phoneNumber});

            Console.WriteLine("Numara eklenmiştir.");
            Console.ReadKey();
        }

        public static void PhoneNumberList()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("******************************************");
            foreach (var item in Kisiler)
            {
                Console.WriteLine($"İsim                :{item.FirstName}");
                Console.WriteLine($"Soyisim             :{item.LastName}");
                Console.WriteLine($"Telefon Numarası    :{item.PhoneNumber}");
                Console.WriteLine("*");
            }

            Console.WriteLine($"Rehberde {Kisiler.Count} mevcuttur.Ana menüye dönemk için bir tuşa basınız..");
            Console.ReadKey();
        }

        public static void PhoneNumberDelete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını yada soyadını giriniz :");
            string name = Console.ReadLine();
            foreach (var item in Kisiler)
            {
                if (item.FirstName == name || item.LastName == name)
                {
                    Console.Write(item.FirstName + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                    char check = char.Parse(Console.ReadLine());
                    if (check == 'y')
                    {
                        Kisiler.Remove(item);
                        Console.WriteLine(item.FirstName + "Başarı ile silindi.");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;
                    }
                    else if (check == 'n')
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.Lütfen başka bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonladırmak için :(1)");
                    Console.WriteLine("Yeniden denemek için     :(2)");
                    var secim = Console.ReadLine();
                    if (secim == "1") { return; }
                    else if (secim == "2") { PhoneNumberDelete(); }
                    else { Console.WriteLine("Geçersiz bir karakter giriniz"); Console.ReadKey(); }
                }
            }
        }
        public static void PhoneNumberSearch()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**************************************");
            Console.WriteLine("İsim veya soyisim ile arama yapmak için (1)   :");
            Console.WriteLine("Telefon numarasına göre arama yapmak için (2) :");
            char selection = char.Parse(Console.ReadLine());
            if (selection == '1')
            {
                Console.Clear();
                Console.Write("İsim veya soyisim giriniz.");
                string name = Console.ReadLine();
                foreach (var item in Kisiler)
                {
                    if (item.FirstName == name || item.LastName == name)
                    {
                        Console.WriteLine("İsim : " + item.FirstName);
                        Console.WriteLine("Soyisim :" + item.LastName);
                        Console.WriteLine("Telefon Numarası :" + item.PhoneNumber);
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı.");
                Console.ReadKey();
            }
            else if (selection == '2')
            {
                Console.Clear();
                Console.WriteLine("Telefon numarasını giriniz.");
                string telefonNo = Console.ReadLine();
                foreach (var item in Kisiler)
                {
                    if (item.PhoneNumber ==telefonNo )
                    {
                        Console.WriteLine("İsim :" + item.FirstName);
                        Console.WriteLine("Soyisim :" + item.LastName);
                        Console.WriteLine("Telefon Numarası :" + item.PhoneNumber);
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı");
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız.");
            }
        }

        public static void PhoneNumberUpdate()
        {
            List<PhoneBookSabitler> Kisiler1 = new List<PhoneBookSabitler>();
            Console.Clear();
            Console.WriteLine("Güncellemek istediğiniz kişinin adını yada soyadını giriniz.");
            string name = Console.ReadLine();
            foreach (var item in Kisiler)
            {
                if (item.FirstName == name || item.LastName == name)
                {
                    Console.WriteLine("İsim :" + item.FirstName);
                    Console.WriteLine("Soyisim :" + item.LastName);
                    Console.WriteLine("Telefon Numarası :" + item.PhoneNumber);
                    Console.WriteLine();
                    Console.Write("Yeni isim gir :");
                    string firstName = Console.ReadLine();
                    Console.Write("Yeni soyisim gir :");
                    string lastName = Console.ReadLine();
                    Console.Write("Yeni numara gir :");
                    string phoneNumber = Console.ReadLine();
                    Kisiler1.Add(new PhoneBookSabitler() { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber });
                    Console.WriteLine("Başarı ile güncellendi.");
                }
                else
                {
                    Kisiler1.Add(new PhoneBookSabitler() { FirstName = item.FirstName, LastName = item.LastName, PhoneNumber = item.PhoneNumber });
                }
            }
            Console.WriteLine("Aradığınız kriterlere uygun veri bulunamadı.Lütfen bir seçim yapınız.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Kisiler.Clear();
                Kisiler = Kisiler1;
            }
            if (selection == 2)
            {
                PhoneNumberUpdate();
            }
            Console.ReadKey();
        }
    }
}
