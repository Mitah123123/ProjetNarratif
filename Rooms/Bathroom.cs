namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"Tu décides de te regarder dans le [miroir].
Tu décides de te [raser].
Tu décides de retourner dans la [chambre].
";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "miroir":
                    {
                        Console.WriteLine("On voit juste notre visage fatigué\n" +
                            "moi: Bordel, quel cauchemar de merde.");
                    }
                    break;
                case "raser":
                    {
                        Console.WriteLine("Tu te rases la barbe.");
                    }break;

                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
