using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Giant : IEntity, IThrow
{
    public string Name { get; set; }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with a terrifying stomp.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} moves forward loudly.");
    }

    public void Throw(IEntity target)
    {
        Console.WriteLine($"{Name} throw a boulder at {target.Name}");
    }
}
