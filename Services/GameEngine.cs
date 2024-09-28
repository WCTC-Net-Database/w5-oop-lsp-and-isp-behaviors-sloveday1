using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _giant;
        private readonly IEntity _healer;
        private readonly IEntity _archer;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity giant, IEntity healer, IEntity archer)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _giant = giant;
            _healer = healer;
            _archer = archer;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _giant.Name = "Giant";
            _healer.Name = "Healer";
            _archer.Name = "Archer";

            _character.Move();
            _goblin.Move();
            _character.Attack(_goblin);
            _goblin.Attack(_character);
            
            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost) _ghost).Fly();
            
            _healer.Move();
            _healer.Attack(_goblin);
            ((Healer) _healer).Heal(_character);
            
            _giant.Move();
            ((Giant) _giant).Throw(_healer);
            
            _archer.Move();
            ((Archer) _archer).Shoot(_giant);
            
        }
    }
}
