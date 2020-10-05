namespace RoleplayGame
{
    public class Armor : Item
    {
        public override int DefenseValue
        {
            get
            {
                return 25;
            }
        }
        public override int AttackValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}