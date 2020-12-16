using System;

namespace HW_sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас зовут {0} и ваш возраст {1}", name, age);

            Console.WriteLine("Введите вашу дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Ваша дата рождения: {0}", birthdate);
            Console.ReadKey();
        }
    }
}
