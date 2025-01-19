namespace Nikonov_DZ_1;

public class Customer
{
    // Имя клиента
    public required string Name { get; set; }
    // Машина клиента
    public Car? Car { get; set; }

    // Возвращает информацию о клиенте
    public override string ToString()
    {
        return $"Имя {Name}, Номер машины: {Car?.Number ?? -1}";
    }
}
