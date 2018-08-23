using System;

namespace StrategyPattern
{
    public class SwordStrategy : IWeaponStrategy
    {
        public void Atack()
        {
            Console.WriteLine("Cortando con la espada");
        }
    }
}
