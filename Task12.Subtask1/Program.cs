using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task12.Subtask1
{

    internal class Program
    {
        static List<User> Users = new List<User>();
        static void Main(string[] args)
        {
            // Имитация заполненного списка
            Users.Add(new User { Login = "Leha", Name = "Alex", IsPremium = false});
            Users.Add(new User { Login = "Dima", Name = "Dmitriy", IsPremium = true});

            UserLogin();
            Console.ReadLine();
        }
        static void UserLogin()
        {
            Console.WriteLine("Введите ваш логин");
            string login = Console.ReadLine();
            foreach (var user in Users)
            {
                if (user.Login == login)
                {
                    Console.WriteLine($"Привет {user.Name}!");
                    if (!user.IsPremium) ShowAds();
                    return;
                }                
            }
            Console.WriteLine("Пользователь с таким логином не найден");
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
