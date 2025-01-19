namespace Nikonov_DZ_1;

public class Car
{
    // Вспомогательный рандомайзер
    private static readonly Random _rand = new();
    // Номер машины
    public required int Number { get; set; }
    // Педальный двигатель
    public Engine Engine { get; }
    
    // Возвращает информацию о машине
    public override string ToString()
    {
        return $"Номер {Number}, размер педалей {Engine.Size}";
    }
    
    // Конструктор класса
    public Car()
    {
        Engine = new Engine { Size = _rand.Next(1, 10) };
    }
}
