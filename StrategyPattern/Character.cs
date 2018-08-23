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


    }
}
