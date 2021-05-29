using System;
using System.Collections.Generic;

namespace Personnel
{
    /// <summary>
    /// Меню программы
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Хранилище кадров
        /// </summary>
        static List<Staff> staffs = new List<Staff>();

        /// <summary>
        /// Инициализация хранилища кадров тестовыми данными
        /// </summary>
        public Menu()
        {
            Engineer engineer = new Engineer("Станислав. В. Д", 5, 80000, 20, 8, 1);
            Worker worker = new Worker("Роженцова Б.Ю.", 12, 45000, 30, 0.3, 2);
            Administration administration = new Administration("Сергей М.В.", 8, 60000, 35, 120000, 45000);

            staffs.Add(engineer);
            staffs.Add(worker);
            staffs.Add(administration);
        }

        /// <summary>
        /// Запуск меню
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Просмотр кадров");
                Console.WriteLine("2. Добавить работника");
                Console.WriteLine("3. Поиск");
                Console.WriteLine("4. Выход");
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1': PrintStaffs(); break;
                    case '2': AddStaffs(); break;
                    case '3': SearchPersons(); break;
                    case '4': Environment.Exit(0); break;
                    default: break;
                }
            }
        }
        /// <summary>
        /// Вывод кадров
        /// </summary>
        public static void PrintStaffs()
        {
            Console.Clear();
            foreach (var item in staffs)
            {
                Console.WriteLine(item);
                Console.WriteLine("========================================");
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// Добавление кадров
        /// </summary>
        public static void AddStaffs()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите вариант:");
                Console.WriteLine("1. Инженер");
                Console.WriteLine("2. Рабочий");
                Console.WriteLine("3. Администратор");
                choice = Console.ReadKey(true).KeyChar;
            }
            while (choice != '1' && choice != '2' && choice != '3');

            switch (choice)
            {
                case '1'://Инженер
                    {
                        string name;
                        int workExperience;
                        double salary;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите стаж работы: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out workExperience) || workExperience < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите ЗП: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0);


                        int projectsImplemented;
                        int subordinateWorker;
                        int projectsFailed;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество реализованных проектов: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out projectsImplemented) || projectsImplemented < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество сотрудников в подчинении: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out subordinateWorker) || subordinateWorker < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество проваленных проектов: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out projectsFailed) || projectsFailed < 0);


                        staffs.Add(new Engineer(name, workExperience, salary, projectsImplemented, subordinateWorker, projectsFailed)); break;
                    }
                case '2'://Рабочий
                    {
                        string name;
                        int workExperience;
                        double salary;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите стаж работы: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out workExperience) || workExperience < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите ЗП: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0);


                        double producesPartsPerHour;
                        double drinksCoffeePerHour;
                        int tardinessPerMonth;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество производимых детелей в час: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out producesPartsPerHour) || producesPartsPerHour < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество чашек кофе выпиваемых в час: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out drinksCoffeePerHour) || drinksCoffeePerHour < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество опозданий в месяц: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out tardinessPerMonth) || tardinessPerMonth < 0);


                        staffs.Add(new Worker(name, workExperience, salary, producesPartsPerHour, drinksCoffeePerHour, tardinessPerMonth)); break;
                    }
                case '3'://Администратор
                    {
                        string name;
                        int workExperience;
                        double salary;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите имя: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите стаж работы: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out workExperience) || workExperience < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите ЗП: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0);


                        int reprimandsMade;
                        double bonusesPaid;
                        double finesIssued;


                        do
                        {
                            Console.Clear();
                            Console.Write("Введите количество сделанных выговоров: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out reprimandsMade) || reprimandsMade < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите сумму выплаченных премий: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out bonusesPaid) || bonusesPaid < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите сумму выписанных штрафов: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out finesIssued) || finesIssued < 0);


                        staffs.Add(new Administration(name, workExperience, salary, reprimandsMade, bonusesPaid, finesIssued)); break;
                    }
                default: throw new Exception("Ошибка");
            }
        }

        /// <summary>
        /// Поиск работника по заданной строке
        /// </summary>
        public static void SearchPersons()
        {
            Console.Clear();
            Console.Write("Введите строку для поиска: ");
            string searchText = Console.ReadLine();
            Console.WriteLine("========================================");

            foreach (var item in staffs)
            {
                if (item.IsContains(searchText))
                {
                    Console.WriteLine(item);
                    Console.WriteLine("========================================");
                }
            }
            Console.ReadKey(true);
        }
    }
}
