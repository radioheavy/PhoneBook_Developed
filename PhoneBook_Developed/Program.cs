using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            bool isRunning = true;
            
                while (isRunning)
            {
                Console.WriteLine("1. Yeni kayıt ekle");
                Console.WriteLine("2. Kayıt güncelle");
                Console.WriteLine("3. Kayıt sil");
                Console.WriteLine("4. Kayıtları listele");
                Console.WriteLine("5. Çıkış");

                Console.Write("Seçiminiz: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("İsim: ");
                        string name = Console.ReadLine();
                        Console.Write("Telefon numarası: ");
                        string phoneNumber = Console.ReadLine();
                        phoneBook.Add(name, phoneNumber);
                        break;
                    case 2:
                        Console.Write("Güncelleme yapılacak isim: ");
                        string updateName = Console.ReadLine();
                        if (phoneBook.ContainsKey(updateName))
                        {
                            Console.Write("Yeni telefon numarası: ");
                            string newPhoneNumber = Console.ReadLine();
                            phoneBook[updateName] = newPhoneNumber;
                            Console.WriteLine("Kayıt güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir kayıt bulunamadı.");
                        }
                        break;
                    case 3:
                        Console.Write("Silinecek isim: ");
                        string deleteName = Console.ReadLine();
                        if (phoneBook.ContainsKey(deleteName))
                        {
                            phoneBook.Remove(deleteName);
                            Console.WriteLine("Kayıt silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir kayıt bulunamadı.");
                        }
                        break;
                    case 4:
                        foreach (KeyValuePair<string, string> entry in phoneBook)
                        {
                            Console.WriteLine($"İsim: {entry.Key} - Telefon Numarası: {entry.Value}");
                        }
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim yaptınız.");
                        break;
                }
            }
        }
    }
}