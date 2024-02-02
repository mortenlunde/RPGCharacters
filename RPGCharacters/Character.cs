namespace RPGCharacters
{
    public class Character
    {
        protected string Name { get; }
        private string Description { get; }
        protected Weapon EquippedWeapon { get; }

        protected Character(string name, string description, Weapon weapon)
        {
            Name = name;
            Description = description;
            EquippedWeapon = weapon;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} the {Description} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

// Subclasses for Character
    public class Fighter(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            string description = GetType().Name;
            Console.WriteLine(
                $"{Name} the {description.ToLower()} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Wizard(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            string description = GetType().Name;
            Console.WriteLine(
                $"{Name} the {description.ToLower()} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Rogue(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            string description = GetType().Name;
            Console.WriteLine(
                $"{Name} the {description.ToLower()} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }

    public class Ranger(string name, string description, Weapon weapon) : Character(name, description, weapon)
    {
        public override void Attack()
        {
            string description = GetType().Name;
            Console.WriteLine($"{Name} the {description.ToLower()} attacks with {EquippedWeapon.Description}: {EquippedWeapon.AttackMessage}");
        }
    }
}