namespace Homeworks.FightGame
{
    public class Villain : Character
    {
        public int DarkPower { get; set; }

        public override void Attack(Character characterToAttack)
        {
            characterToAttack.Health -= DarkPower;
        }
    }
}
