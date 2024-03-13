using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var dic = new List<Dictionary<string, object>>();

        // Зчитуємо інформацію від користувача для кожного словника та додаємо її в список
        while (true)
        {
            Console.WriteLine("Введіть id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть success (true або false):");
            bool success = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введіть name:");
            string name = Console.ReadLine();

            var dictionary = new Dictionary<string, object>
            {
                {"id", id},
                {"success", success},
                {"name", name}
            };

            dic.Add(dictionary);

            Console.WriteLine("Продовжити введення? (Y/N)");
            if (Console.ReadLine().ToUpper() != "Y")
            {
                break;
            }
        }

        var successCount = dic.Count(d => d.ContainsKey("success") && (bool)d["success"]);   // Виконуємо пошук і підрахунок словників, де success == True

        Console.WriteLine($"Кількість словників з 'success == True': {successCount}");
    }
}
