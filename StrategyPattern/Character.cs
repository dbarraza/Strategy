using StrategyPattern.implementation;
using StrategyPattern.interfaces;

namespace StrategyPattern
{
    //The Context
    public class Character
    {
        private IWeaponStrategy _weapon;
        public string Name { get; set; }

        public void ChangeWeapon(IWeaponStrategy weapon)
        {
            _weapon = weapon;
        }

        public Character(string name)
        {
            Name = name;
            _weapon = new NoWeaponStrategy();
        }

        public void Atack()
        {
            _weapon.Atack();
        }


    }
}
