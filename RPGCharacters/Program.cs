namespace RPGCharacters
{
    public static class Program
    {
        public static void Main()
        {
            List<Character> characters =
            [
                new Fighter("Mohammed Ali", "American professional boxer", new Dagger("dagger", "klink!")),
                new Wizard("Gandalf", "He is a wizard, one of the Istari order", new Wand("wand", "avada kadavra!")),
                new Rogue("Bellatrix", "Female warrior", new Sword("dagger", "squeek")),
                new Ranger("Bob Lee Swagger", "Bob Lee Swagger is a retired Marine gunnery sergeant",
                    new Bow("bow", "a kill from 1000 yards"))
            ];

            // Test attacks
            foreach (Character character in characters)
            {
                character.Attack();
            }
        }
    }
}