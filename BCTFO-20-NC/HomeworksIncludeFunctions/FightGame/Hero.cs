namespace Homeworks.FightGame
{
    public class Hero : Character
    {
        public int LightPower { get; set; }

        public override void Attack(Character characterToAttack)
        {
            characterToAttack.Health -= LightPower;
        }

        public void Heal(Hero heroToHeal, int healCount)
        {
            if (Health > healCount)
            {
                Health -= healCount;
                heroToHeal.Health += healCount;
            }
        }
    }
}
