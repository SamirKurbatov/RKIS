// Принцип единственной ответственности (Single Responsibility Principle)
public class EmployeeData
{
    public string Name { get; set; }
}

public class EmployeeRepository
{
    public void SaveEmployee(EmployeeData employee)
    {
        // Логика сохранения сотрудника в базе данных
    }
}

public class EmployeeService
{
    public decimal CalculateSalary(EmployeeData employee)
    {
        // Логика расчета зарплаты
        return 0;
    }
}

// Принцип открытости/закрытости (Open/Closed Principle)
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

// Принцип подстановки Барбары Лисков (Liskov Substitution Principle)
public interface IShape
{
    double Area();
}

public class LiskovCircle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class LiskovRectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

// Принцип разделения интерфейса (Interface Segregation Principle)
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public class Worker : IWorker
{
    public void Work()
    {
        // Логика работы
    }
}

public class SuperWorker : IWorker, IEater
{
    public void Work()
    {
        // Логика работы
    }

    public void Eat()
    {
        // Логика приема пищи
    }
}

// Принцип инверсии зависимостей (Dependency Inversion Principle)
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class WorkerWithLogger
{
    private readonly ILogger logger;

    public WorkerWithLogger(ILogger logger)
    {
        this.logger = logger;
    }

    public void DoWork()
    {
        // Логика работы
        logger.Log("Work done");
    }
}