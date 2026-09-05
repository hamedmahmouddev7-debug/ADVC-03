using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    //public static class PhoneBook
    //{
    //    public static void Run()
    //    {
    //        Console.WriteLine("=== Phone Book ===");

    //        Dictionary<string, string> phoneBook = new Dictionary<string, string>
    //    {
    //        { "Ahmed", "01011111111" },
    //        { "Sara", "01022222222" },
    //        { "Ali", "01033333333" },
    //        { "Mona", "01044444444" }
    //    };
    //        phoneBook["Omar"] = "01055555555";
    //        Console.WriteLine("Added Omar using [] syntax.");

    //        try
    //        {
    //            phoneBook.Add("Ahmed", "01099999999");
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine($"Error adding duplicate with .Add(): {ex.Message}");
    //        }

    //        bool added = phoneBook.TryAdd("Sara", "01088888888");
    //        Console.WriteLine($"TryAdd duplicate 'Sara' succeeded: {added}");

    //        bool contactExists = phoneBook.ContainsKey("Khaled");
    //        Console.WriteLine($"Contact 'Khaled' Exists: {contactExists}");
    //        string phone = phoneBook.GetValueOrDefault("Khaled", "Not Found");
    //        Console.WriteLine($"Khaled's Phone: {phone}");

    //        Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
    //        Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
    //    }
    //}
}
