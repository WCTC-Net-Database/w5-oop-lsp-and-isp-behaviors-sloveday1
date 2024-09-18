namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        void Attack(IEntity target);
        void Move();
        void Fly();
        string Name { get; set; }
    }

}
