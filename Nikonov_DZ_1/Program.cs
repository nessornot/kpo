namespace Nikonov_DZ_1;
// ДЗ 1
// Никонов Андрей Алексеевич 
// Группа БПИ238-1


internal class Program
{
    static void Main()
    {
        // Список клиентов
        var customers = new List<Customer>
        {
            new() { Name = "Ivan" },
            new() { Name = "Petr" },
            new() { Name = "Sidr" },
        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 5; i++)
        {
            factory.AddCar();
        }
        
        Console.WriteLine("До:");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();

        Console.WriteLine("После:");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
    }
}
