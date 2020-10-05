namespace RoleplayGame
{
    public class Wizard : Character
    {
        private int health = 100;

        public Wizard(string name)
            :base(name)
        {
        }
        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public override int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
            }
        }

    }
}