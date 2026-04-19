using System;
public interface IMachine
{
    string Name { get; set; }
    void Start();
    void Stop();
    string GetInfo();
}
public interface IHeavy
{
    void LoadCargo(int tons);
    int GetCargoWeight();
}
public abstract class Machine : IMachine
{
    public string Name { get; set; }
    public abstract void Start();
    public abstract void Stop();
    public virtual string GetInfo() => $"{Name} (базовая машина)";
}
public class HeavyMachine : Machine, IHeavy
{
    private int cargoWeight = 0;
    public HeavyMachine(string name) => Name = name;

    public override void Start() => Console.WriteLine($"{Name}: тяжелая машина запущена");
    public override void Stop() => Console.WriteLine($"{Name}: тяжелая машина остановлена");
    public override string GetInfo() => $"{Name} (тяжелая техника)";
    public void LoadCargo(int tons) { cargoWeight = tons; Console.WriteLine($"{Name}: загружено {tons} т"); }
    public int GetCargoWeight() => cargoWeight;
}
public class MediumMachine : Machine
{
    public MediumMachine(string name) => Name = name;
    public override void Start() => Console.WriteLine($"{Name}: средняя машина запущена");
    public override void Stop() => Console.WriteLine($"{Name}: средняя машина остановлена");
    public override string GetInfo() => $"{Name} (средняя техника)";
}
public class Tractor : HeavyMachine
{
    public Tractor(string name) : base(name) { }
    public override void Start() => Console.WriteLine($"{Name}: трактор завелся");
    public override void Stop() => Console.WriteLine($"{Name}: трактор заглушен");
    public override string GetInfo() => $"{Name} (трактор)";
}
public class Combine : HeavyMachine
{
    public Combine(string name) : base(name) { }
    public override void Start() => Console.WriteLine($"{Name}: комбайн начал уборку");
    public override void Stop() => Console.WriteLine($"{Name}: комбайн остановлен");
    public override string GetInfo() => $"{Name} (комбайн)";
}
class Program
{
    static void Main()
    {
        IMachine[] machines = new IMachine[4];
        machines[0] = new HeavyMachine("Бульдозер");
        machines[1] = new MediumMachine("Погрузчик");
        machines[2] = new Tractor("Беларус");
        machines[3] = new Combine("Дон-1500");

        Console.WriteLine("=== Полиморфизм (IMachine) ===\n");
        foreach (IMachine m in machines)
        {
            m.Start();
            m.Stop();
            Console.WriteLine(m.GetInfo());
            Console.WriteLine();

            if (m is IHeavy heavy)
            {
                heavy.LoadCargo(10);
                Console.WriteLine($"Груз: {heavy.GetCargoWeight()} т\n");
            }
        }
        Console.ReadKey();
    }
}