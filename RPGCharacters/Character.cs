namespace RPGCharacters
{
    public class Character
    {
        protected string Name { get; set; }
        public string Description { get; set; }
        protected Weapon EquippedWeapon { get; set; }

        protected Character(string name, string description, Weapon weapon)
        {
            Name = name;
            Description = description;
            EquippedWeapon = weapon;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

// Subclasses for Character
    public class Fighter(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} the Fighter attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Wizard(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} the Wizard attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Rogue(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} the Rogue attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Ranger(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} the Ranger attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }
}