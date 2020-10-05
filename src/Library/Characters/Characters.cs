namespace RoleplayGame
{
    public abstract class Character
    {
        public Character (string name)
        {
            this.Name = name;
        }

        private int health= 100; 
        
        public string Name {get; set;}
        
        public abstract int AttackValue {get;}

        public abstract int DefenseValue {get;}

        public int Health 
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}