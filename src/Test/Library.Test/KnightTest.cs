using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class KnightTest
    {
        private Knight human;
        private Sword sword;
        private Shield shield;
        private Armor armor;
        [SetUp]
        public void Setup()
        {
            sword = new Sword();
            shield = new Shield();
            armor = new Armor();
            human = new Knight("Pedro");
            human.Sword = sword;
            human.Shield = shield;
            human.Armor = armor;
        }
        [Test]
        public void TestAtaqueTotal()
        {
            Assert.AreEqual(this.human.AttackValue, this.sword.AttackValue);
        }

        [Test]
        public void TestDefensaTotal()
        {
            Assert.AreEqual(this.human.DefenseValue, this.shield.DefenseValue + this.armor.DefenseValue);
        }

        [Test]
        public void CurarTest()
        {
            int attack = 70;
            this.human.ReceiveAttack(attack);
            Assert.AreEqual(this.human.Health, (100 - (attack - this.human.DefenseValue)) );

            this.human.Cure();
            Assert.AreEqual(this.human.Health, 100);
        }
        [Test]
        public void RecibirAtaqueTest()
        {
            int attack = 80;
            this.human.ReceiveAttack(attack);
            Assert.AreEqual(this.human.Health, (100 - (attack - this.human.DefenseValue)) );
        }
    }


}