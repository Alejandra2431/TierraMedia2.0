namespace RoleplayGame
{
    public class Axe: Item
    {
        public override int AttackValue 
        {
            get
            {
                return 25;
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