using NUnit.Framework;
using RoleplayGame;
namespace Test.Library
{


    public class WizardTest
    {
        private Wizard wizard; 
        private SpellsBook spellsBook;
        private Staff staff;
        private Spell spell;

        [SetUp]
        public void Setup()
        {
            wizard = new Wizard("Gandalf");
            spellsBook = new SpellsBook();
            staff = new Staff();
            spell = new Spell();

            spellsBook.Spells = new Spell[]{spell};
            wizard.SpellsBook = spellsBook;
            wizard.Staff = staff;
        }

        [Test]
        public void AtaqueTotalTest()
        {
            Assert.AreEqual(this.wizard.AttackValue, this.staff.AttackValue + this.spellsBook.AttackValue);
        }
        [Test]
        public void DefensaTotalTest()
        {
            Assert.AreEqual(this.wizard.DefenseValue, this.spellsBook.DefenseValue + this.staff.DefenseValue);
        }
        [Test]
        public void CurarTest()
        {
            int attack = 180;
            this.wizard.ReceiveAttack(attack);
            Assert.AreEqual(this.wizard.Health, (100 - (attack - this.wizard.DefenseValue)) );

            this.wizard.Cure();
            Assert.AreEqual(this.wizard.Health, 100);
        }
        [Test]
        public void RecibirAtaqueTest()
        {
            int attack = 200;
            this.wizard.ReceiveAttack(attack);
            Assert.AreEqual(this.wizard.Health, (100 - (attack - this.wizard.DefenseValue)) );
        }
    }
}