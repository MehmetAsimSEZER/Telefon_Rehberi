namespace Telefon_Rehberi
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBookList.CreatePhoneBook();
            string secim = "";
            while (secim != "exit")
            {
                Console.Clear();
                Console.WriteLine("\nProgramdan çıkış için 'exit' giriniz.");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Yeni numara kaydetmek");
                Console.WriteLine("(2) Varolan numarayı silmek");
                Console.WriteLine("(3) Varolan numarayı güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde arama yapmak");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz");
                secim = Console.ReadLine().ToLower();

                switch (secim)
                {
                    case "1":
                        PhoneBookList.PhoneNumberAdd();
                        break;
                    case "2":
                        PhoneBookList.PhoneNumberDelete();
                        break;
                    case "3":
                        PhoneBookList.PhoneNumberUpdate();
                        break;
                    case "4":
                        PhoneBookList.PhoneNumberList();
                        break;
                    case "5":
                        PhoneBookList.PhoneNumberSearch();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("1 ile 5 arası seçim yapınız yada exit ile çıkınız.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
