using System;
using StrategyPattern.interfaces;

namespace StrategyPattern.implementation
{
    public class GunStrategy : IWeaponStrategy
    {
        public void Atack()
        {
            Console.WriteLine("Disparando con una pistola...");
        }
    }
}
