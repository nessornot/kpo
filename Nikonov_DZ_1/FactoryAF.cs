namespace Nikonov_DZ_1;

public class FactoryAF
{
    // Список автомобилей
    public List<Car> Cars { get; private set; }
    // Список клиентов
    public List<Customer> Customers { get; private set; }

    // Конструктор класса
    public FactoryAF(List<Customer> customers)
    {
        Customers = customers;
        Cars = [];
    }

    // Продает автомобили
    internal void SaleCar()
    {
        foreach (var i in Customers)
        {
            i.Car ??= Cars.LastOrDefault();

            if (i.Car == null)
                break;

            Cars.RemoveAt(Cars.Count - 1);
        }

        Customers = Customers.Where(customer => customer.Car != null).ToList();
        Cars.Clear();
    }

    // Добавляет машину в список
    internal void AddCar()
    {
        Cars.Add(new Car { Number = Cars.Count + 1 });
    }
}
