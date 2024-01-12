namespace Homeworks.FightGame
{
    public abstract class Character
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public int Health { get; set; }

        public abstract void Attack(Character characterToAttack);
    }
}
