namespace RPGCharacters
{
    public class Weapon(string description, string attackMessage)
    {
        public string Description { get; set; } = description;
        public string AttackMessage { get; set; } = attackMessage;
    }

    public class Sword(string description, string attackMessage) : Weapon(description, attackMessage);

    public class Dagger(string description, string attackMessage) : Weapon(description, attackMessage);

    public class Bow(string description, string attackMessage) : Weapon(description, attackMessage);

    public class Staff(string description, string attackMessage) : Weapon(description, attackMessage);

    public class Wand(string description, string attackMessage) : Weapon(description, attackMessage);
}