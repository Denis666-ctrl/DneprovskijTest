using System;
using InspectorLib;

namespace TestInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspect = new FunctionInsp();

            Console.WriteLine("Главный инспектор: " + inspect.GetInspector());

            Console.WriteLine("Название автоинспекции: " + inspect.GetCarInspection());

            Console.WriteLine("Изменение главного инспектора:");
            Console.WriteLine(inspect.SetInspector("Иванов И.И.") ? "Успешно" : "Ошибка");

            Console.WriteLine("Сгенерированный номер: " + inspect.GenerateNumber(123, 'A', 75));

            Console.WriteLine("Список сотрудников:");
            foreach (var worker in inspect.GetWorker())
                Console.WriteLine(worker);

            inspect.AddWorker("Днепровский Д.Д.");
            Console.WriteLine("Список сотрудников после добавления:");
            foreach (var worker in inspect.GetWorker())
                Console.WriteLine(worker);
        }
    }
}
