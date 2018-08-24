using StrategyPattern.implementation;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var personaje = new Character("Paladin");
            personaje.Atack();

            //Cambiando a una super espada
            personaje.ChangeWeapon(new SwordStrategy());

            //Ahora si
            personaje.Atack();
        }
    }
}
