using System;
using StrategyPattern.interfaces;

namespace StrategyPattern.implementation
{
    public class SwordStrategy : IWeaponStrategy
    {
        public void Atack()
        {
            Console.WriteLine("Cortando con la espada....");
        }
    }
}
