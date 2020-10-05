namespace RoleplayGame
{
    public class Dwarf : Character
    {
        public Dwarf(string name)
            :base(name)
        {
        }
        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public override int AttackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }

    }
}