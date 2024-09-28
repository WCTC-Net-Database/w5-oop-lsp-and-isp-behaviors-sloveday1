using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Healer : IEntity, IHeal
{
    public string Name { get; set; }
    
    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} moves forward.");
    }

    public void Heal(IEntity injured)
    {
        Console.WriteLine($"{Name} heals {injured.Name}");
    }
}
