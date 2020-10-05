using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTest
    {
        private Dwarf dwarf;
        private Helmet helmet;
        private Axe axe;
        private Shield shield;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe();
            shield = new Shield();
            helmet = new Helmet();
            dwarf = new Dwarf("Gimly");
            dwarf.Axe = axe;
            dwarf.Helmet = helmet;
            dwarf.Shield = shield;
        }

        [Test]
        public void AtaqueTotalTest()
        {
            Assert.AreEqual(this.dwarf.AttackValue, this.axe.AttackValue);
        }
        [Test]
        public void DefensaTotalTest()
        {
            Assert.AreEqual(this.dwarf.DefenseValue, this.helmet.DefenseValue + this.shield.DefenseValue);
        }
        [Test]
        public void CurarTest()
        {
            int attack = 60;
            this.dwarf.ReceiveAttack(attack);
            Assert.AreEqual(this.dwarf.Health, (100 - (attack - this.dwarf.DefenseValue)) );

            this.dwarf.Cure();
            Assert.AreEqual(this.dwarf.Health, 100);
        }
        [Test]
        public void RecibirAtaqueTest()
        {
            int attack = 70;
            this.dwarf.ReceiveAttack(attack);
            Assert.AreEqual(this.dwarf.Health, (100 - (attack - this.dwarf.DefenseValue)) );
        }
    }
}