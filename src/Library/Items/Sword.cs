namespace RoleplayGame
{
    public class Sword: Item
    {
        public override int AttackValue 
        {
            get
            {
                return 20;
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