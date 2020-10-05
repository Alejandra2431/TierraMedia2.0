namespace RoleplayGame
{
    public class Bow: Item
    {
        public override int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
        public override int DefenseValue
        {
            get
            {
                return 0;
            }
        }
    }
}