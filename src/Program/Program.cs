using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        /*
         Herencia: Con respecto a este punto se procedió a crear dos clases abstractas (Characters y Item) con el fin de
         reutilizar el código dado que los characters e items presentan caracteristicas en común, lo cual se pudo sacar provecho
         por medio de herencia.  
         Gracias a herencia se podría aplicar el patrón polymorphism, por ejemplo si quisieramos crear una clase nuevo que enfrente
         a los characters entre si, ello es posible dado que todos los personajes comparten metodos en común que heredan de la
         superclase "Character".
         También nos permite la herencia cumplir con el patrón OCP, dado que el código logrado está abierto a extensiones y cerrado
         a las modificaciones, por ejemplo en caso de crear más personajes e items, simplemente heredando de character o item sus metodos
         cumplen con el principio LSP O sustitución. 
        */
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
