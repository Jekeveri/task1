using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> placesAndTeams = new Dictionary<string, string>();
            placesAndTeams.Add("Москва", "ЦСКА");
            placesAndTeams.Add("Санкт-Петербург", "Зенит");
            placesAndTeams.Add("Казань", "Рубин");
            placesAndTeams.Add("Екатеринбург", "Урал");
            placesAndTeams.Add("Краснодар", "Краснодар");
            placesAndTeams.Add("Ростов-на-Дону", "Ростов");
            placesAndTeams.Add("Нижний Новгород", "Олимпиец");
            placesAndTeams.Add("Самара", "Крылья Советов");
            placesAndTeams.Add("Волгоград", "Ротор");
            placesAndTeams.Add("Уфа", "Уфа");

            Console.Write("Введите название города: ");
            string city = Console.ReadLine();

            if (placesAndTeams.ContainsKey(city))
            {
                Console.WriteLine($"Команда из города {city}: {placesAndTeams[city]}");

                Console.Write("Этот элемент будет удален словаря ");
                placesAndTeams.Remove(city);

                Console.WriteLine("Оставшиеся элементы словаря:");
                foreach (KeyValuePair<string, string> i in placesAndTeams)
                {
                    Console.WriteLine($"{i.Key}: {i.Value}");
                }

                Console.Write("Удаление всех элементов словаря ");
                placesAndTeams.Clear();
            }
            else
            {
                Console.WriteLine($"В словаре нет информации о городе {city}");
            }

            Console.ReadLine();
        }
    }
}
