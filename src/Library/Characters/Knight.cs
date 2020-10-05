namespace RoleplayGame
{
    public class Knight : Character
    {

        public Knight(string name)
            :base(name)
        {
        }
        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public override int AttackValue
        {
            get
            {
                return Sword.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }
        }
    }
}