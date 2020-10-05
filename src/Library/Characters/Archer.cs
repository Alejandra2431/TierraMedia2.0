namespace RoleplayGame
{
    public class Archer : Character
    {
        public Archer(string name)
            :base(name)
        {
        }        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public override int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Helmet.DefenseValue;
            }
        }

    }
}