using System;
using StrategyPattern.interfaces;

namespace StrategyPattern.implementation
{
    public class NoWeaponStrategy : IWeaponStrategy
    {
        public void Atack()
        {
            Console.WriteLine("No puedo atacar sin arma");
        }
    }
}
