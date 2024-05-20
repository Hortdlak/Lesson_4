namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Работа на уроке

            #region Введение
            //var numbers = new List<int> { 1,2,3,4,5,6,7};
            //var numbers2 = numbers.MyWhere<int> (x => x > 3);

            //foreach (var number in numbers2)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Задача 1: Фильтрация и проекция данных с использованием LINQ

            //List<Student> students = ExternalList.GetStudents();

            #region Найти всех студентов, чей возраст меньше 25 лет.

            //var findAge = students.Where(x => x.Age > 25).Select(x => x.Name);

            #endregion

            #region Вывести имена всех студентов в алфавитном порядке.

            //var sortName = students.OrderBy(x => x.Name).Select(x => x.Name);

            #endregion

            #region Выбрать студентов, обучающихся на факультете инженерии.

            //var findFacility = students.Where(x => x.Facility.Equals("Engineering")).Select(x => x.Name);

            #endregion

            #region Посчитать средний возраст студентов
            //var averageEge = students.Average(x => x.Age);

            #endregion

            #endregion

            #region Задача 2: Вывести список клиентов и общую сумму их заказов.

            //List<Order> orders = new List<Order>
            //{
            //    new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
            //    new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
            //    new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
            //    new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
            //    new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 }

            //};

            #region Отсортировать заказы по сумме в убывающем порядке

            //var sum = orders.OrderByDescending(x => x.TotalAmount).Select(x => x.OrderID);
            //var sum2 = from order in orders
            //           orderby order.TotalAmount
            //           select order;

            #endregion

            #region Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента

            //var ClientCust = orders.GroupBy(x => x.CustomerName).Select(x => new { name = x.Key, count = x.Count() });

            #endregion

            #region Найти клиента с наибольшей суммой заказов

            //var maxOrder = orders.GroupBy(x => x.CustomerName)
            //    .Select(x => new { name = x.Key,sumTotalAmount = x.Sum(ta=>ta.TotalAmount) })
            //    .OrderByDescending(ta => ta.sumTotalAmount).First().name;

            //Console.WriteLine(maxOrder);

            #endregion

            #region Список клиентов с общей суммой заказов 

            //var maxOrder = orders.GroupBy(x => x.CustomerName)
            //    .Select(x => new { name = x.Key, sumTotalAmount = x.Sum(ta => ta.TotalAmount) });

            #endregion

            #endregion

            #region Задача 3: отсортировать список в порядке возрастания длины строк, используя лямбда-выражение.

            //List<string> strings = new List<string>
            //{
            //    "Apple",
            //    "Banana",
            //    "Cherry",
            //    "Date",
            //    "Fig",
            //    "Grapes"
            //};

            //var result = strings.OrderBy(x => x.Length).ToList();

            #endregion

            #region Задача 4:

            //List<int> numbers = new List<int>() { 1,3,4,7,2,6,12,5,15,11,14,19};

            //numbers.Sort((x,y) => x.CompareTo(y));

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Задача 5: выбрать все строки, содержащие определенную подстроку, с использованием лямбда-выражения
            //List<string> words = new List<string>
            //{
            //    "apple",
            //    "banana",
            //    "cherry",
            //    "date",
            //    "grape",
            //    "kiwi",
            //    "Lemon",
            //};

            //string searchTerm = "an";

            //words.Where(x => x.Contains(searchTerm)).ToList().ForEach(x => Console.WriteLine($"{searchTerm}: содержит {x}"));

            #endregion

            #region Задача 6:

            //List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45, 65, 98, 15, 87, 15, 854, 34, 10, 11, 12, 13, 14 };
            //numbers2.Select(x => x * 2). ToList().ForEach(x => Console.WriteLine(x));

            #endregion

            #region Задача 7: Отфильтровать этот список по определенному критерию, используя лямбда-выражение

            //List<Order> orders = new List<Order> 
            //{
            //    new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
            //    new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
            //    new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
            //    new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
            //    new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 }
            //};

            //orders.Where(x => x.CustomerName.StartsWith("A")).ToList().ForEach(x => Console.WriteLine(x.CustomerName));

            #endregion

            #endregion

            #region Домашнее задание

            int[] numbers = [1, 2, 3, 44, 5, 6, 7, 8, 9, 10, 11];

            int target = 11;

            var finder = new ThreeSumFinder(numbers, target);

            var triplets = finder.FindTriplets();

            if (triplets.Any())
            {
                Console.WriteLine($"Найденные комбинации трех чисел, сумма которых равна {target}");

                foreach (var triplet in triplets)
                {
                    Console.WriteLine($"{triplet[0]} + {triplet[1]} + {triplet[2]}");
                }
            }
            else
            {
                Console.WriteLine($"В массиве не удалось найти три числа, сумма которых равна {target}");
            }

            #endregion
        }
    }
}
