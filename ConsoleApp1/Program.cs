using CourseWorkLibrary.Model;
using CourseWorkLibrary.Repo;
using System.Text;

namespace CourseWorkConsoleApp
{
    class Program
    {
        private static WorkContext _context = new WorkContext();
        private static WorkRepository _workRepository = new WorkRepository(_context);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Додати роботу");
                Console.WriteLine("2. Редагувати роботу");
                Console.WriteLine("3. Видалити роботу");
                Console.WriteLine("4. Показати всі роботи");
                Console.WriteLine("5. Пошук");
                Console.WriteLine("6. Вийти");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddWork();
                        break;
                    case "2":
                        EditWork();
                        break;
                    case "3":
                        DeleteWork();
                        break;
                    case "4":
                        DisplayAllWorks();
                        break;
                    case "5":
                        SearchWork();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void AddWork()
        {
            Console.WriteLine("Введіть дані для нової роботи:");
            Console.Write("Тип: ");
            string type = Console.ReadLine();
            Console.Write("Дисципліна: ");
            string discipline = Console.ReadLine();
            Console.Write("Тема: ");
            string topic = Console.ReadLine();
            Console.Write("Ім'я студента: ");
            string studentName = Console.ReadLine();
            Console.Write("Ім'я викладача: ");
            string supervisorName = Console.ReadLine();
            Console.Write("Група: ");
            string group = Console.ReadLine();
            Console.Write("Рік захисту: ");
            int yearOfDefense = int.Parse(Console.ReadLine());
            Console.Write("Оцінка: ");
            int grade = int.Parse(Console.ReadLine());

            Work newWork = new Work
            {
                Type = type,
                Discipline = discipline,
                Topic = topic,
                StudentName = studentName,
                SupervisorName = supervisorName,
                Group = group,
                YearOfDefense = yearOfDefense,
                Grade = grade
            };

            _workRepository.AddWork(newWork);
            Console.WriteLine("Роботу успішно додано.");
        }

        static void EditWork()
        {
            Console.WriteLine("Введіть ID роботи, яку потрібно відредагувати:");
            int id = int.Parse(Console.ReadLine());

            Work existingWork = _workRepository.GetWork(id);

            if (existingWork != null)
            {
                Console.WriteLine("Введіть нові дані для роботи:");
                Console.Write("Тип: ");
                existingWork.Type = Console.ReadLine();
                Console.Write("Дисципліна: ");
                existingWork.Discipline = Console.ReadLine();
                Console.Write("Тема: ");
                existingWork.Topic = Console.ReadLine();
                Console.Write("Ім'я студента: ");
                existingWork.StudentName = Console.ReadLine();
                Console.Write("Ім'я викладача: ");
                existingWork.SupervisorName = Console.ReadLine();
                Console.Write("Група: ");
                existingWork.Group = Console.ReadLine();
                Console.Write("Рік захисту: ");
                existingWork.YearOfDefense = int.Parse(Console.ReadLine());
                Console.Write("Оцінка: ");
                existingWork.Grade = int.Parse(Console.ReadLine());

                _workRepository.EditWork(existingWork);
                Console.WriteLine("Роботу успішно відредаговано.");
            }
            else
            {
                Console.WriteLine($"Роботу з ID {id} не знайдено.");
            }
        }

        static void DeleteWork()
        {
            Console.WriteLine("Введіть ID роботи, яку потрібно видалити:");
            int id = int.Parse(Console.ReadLine());

            Work existingWork = _workRepository.GetWork(id);

            if (existingWork != null)
            {
                _workRepository.DeleteWork(id);
                Console.WriteLine("Роботу успішно видалено.");
            }
            else
            {
                Console.WriteLine($"Роботу з ID {id} не знайдено.");
            }
        }

        static void DisplayAllWorks()
        {
            var works = _workRepository.GetAllWorks();
            Console.WriteLine("Всі роботи:");
            foreach (var work in works)
            {
                Console.WriteLine($"ID: {work.Id}, Тип: {work.Type}, Дисципліна: {work.Discipline}, Тема: {work.Topic}, Студент: {work.StudentName}, Викладач: {work.SupervisorName}, Група: {work.Group}, Рік захисту: {work.YearOfDefense}, Оцінка: {work.Grade}");
            }
        }

        static void SearchWork()
        {
            Console.WriteLine("Оберіть критерій пошуку:");
            Console.WriteLine("1. Рік захисту");
            Console.WriteLine("2. Прізвище студента");
            Console.WriteLine("3. Прізвище викладача");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Введіть рік захисту: ");
                    int year = int.Parse(Console.ReadLine());
                    var worksByYear = _workRepository.GetWorksByYear(year);
                    DisplayWorks(worksByYear);
                    break;
                case "2":
                    Console.Write("Введіть прізвище студента: ");
                    string studentLastName = Console.ReadLine();
                    var worksByStudent = _workRepository.GetWorksByStudentLastName(studentLastName);
                    DisplayWorks(worksByStudent);
                    break;
                case "3":
                    Console.Write("Введіть прізвище викладача: ");
                    string supervisorName = Console.ReadLine();
                    var worksBySupervisor = _workRepository.GetWorksBySupervisor(supervisorName);
                    DisplayWorks(worksBySupervisor);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }

        static void DisplayWorks(List<Work> works)
        {
            if (works.Count == 0)
            {
                Console.WriteLine("Роботи за вказаним критерієм не знайдено.");
            }
            else
            {
                Console.WriteLine("Роботи, що відповідають критерію пошуку:");
                foreach (var work in works)
                {
                    Console.WriteLine($"ID: {work.Id}, Тип: {work.Type}, Дисципліна: {work.Discipline}, Тема: {work.Topic}, Студент: {work.StudentName}, Викладач: {work.SupervisorName}, Група: {work.Group}, Рік захисту: {work.YearOfDefense}, Оцінка: {work.Grade}");
                }
            }
        }

    }
}
