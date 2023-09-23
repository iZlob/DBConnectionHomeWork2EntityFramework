using Microsoft.EntityFrameworkCore;
using MySqlBuilder;
using MySqlConnector;
using System.Data.Common;

using DBConnectionHomeWork2EntityFramework.DB;


using (var DB = new DataBase())
{
    var workers = DB.workers.Select(x => new Tuple<int, string>(x.Id, x.Name)).ToArray();
    Console.WriteLine("Workers DB:\n");
    Console.Write("Id\t");
    Console.WriteLine("Name");
    for (int i = 0; i < workers.Length; i++)
    {
        Console.Write($"{workers[i].Item1}\t");
        Console.WriteLine(workers[i].Item2);
    }
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.WriteLine();
    //////////////////////////////////////////////////////////////////////////////////////////////

    var cars = DB.cars.Select(x => new Tuple<int, string, string>(x.Id, x.Manufacturer, x.Model)).ToArray();
    Console.WriteLine("Cars DB:\n");
    Console.Write("Id\t");
    Console.Write("Manufacturer\t");
    Console.WriteLine("Model");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.Write($"{cars[i].Item1}\t");
        Console.Write($"{cars[i].Item2}\t\t");
        Console.WriteLine(cars[i].Item3);
    }
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.WriteLine();
    //////////////////////////////////////////////////////////////////////////////////////////////

    var orders = DB.orders.Select(x => new Tuple<int, int, int, int, string, string>(x.Id, x.AccepcerId, x.RepairerId, x.CarId, x.Defect, x.Fixed)).ToArray();
    Console.WriteLine("Orders DB:\n");
    Console.Write($"{"Id",-5}");
    Console.Write($"{"Accepcer",-15}");
    Console.Write($"{"Repairer",-15}");
    Console.Write($"{"Car",-15}");
    Console.Write($"{"Defect",-30}");
    Console.WriteLine($"{"Fixed",-30}");
    for (int i = 0; i < orders.Length; i++)
    {
        Console.Write($"{orders[i].Item1,-5}");

        for (int j = 0; j < workers.Length; j++)
        {
            if (workers[j].Item1 == orders[i].Item2)
            {
                Console.Write($"{workers[j].Item2,-15}");
                break;
            }
        }
        for (int j = 0; j < workers.Length; j++)
        {
            if (workers[j].Item1 == orders[i].Item3)
            {
                Console.Write($"{workers[j].Item2,-15}");
                break;
            }
        }
        for (int j = 0; j < cars.Length; j++)
        {
            if (cars[j].Item1 == orders[i].Item4)
            {
                Console.Write($"{cars[j].Item2 + " " + cars[j].Item3,-15}");
                break;
            }
        }
        Console.Write($"{orders[i].Item5,-30}");
        Console.WriteLine($"{orders[i].Item6,-30}");
    }
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.WriteLine();
}