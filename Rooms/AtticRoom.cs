namespace ProjetNarratif.Rooms
{
    internal class Travail : Room
    {
        internal override string CreateDescription() =>
@"Tu arrives au travail et ton boss à pas l'air content. 
Boss : Putain elle nous a laché.
Toi : Qui ça ?
Boss : Gwen ! Elle a démisionné.
Toi : Pourquoi ???? et le dossier pour la semaine prochaine dans tout ça ? 
Boss : C'est à cause de ce Leblanc elle a peur pour sa vie vu qu'elle fini très tard le soir.
Toi : Compréhensible, les victimes de ce malade sont tellement nombreuses.
Boss : Je suis obligé de compter pour toi pour le dossier. Si tu t'en occupes tu auras une prime à la fin du mois.

Allez vous accepter ? 

Toi : [Oui] avec plaisir, tu peux compter sur moi.
Toi : [Non] désolé, je peux pas me permettre de faire ça.
";

        internal override void ReceiveChoice(string choice)
        {          
            switch (choice)
            {
                case "oui":
                    int i = 0;
                    while (i < 10)
                    {
                        Console.WriteLine("Boss : PARFAIT ! avec toi dessus c'est sûr que c'est plié. \n");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int j = 0; j < 10; j++)
                        {
                            if (i == j)
                            {
                                Console.ResetColor();
                            }
                            Console.Write("\u25A0");
                        }
                        Console.ResetColor();
                        Console.WriteLine("]");
                        i++;
                        Thread.Sleep(1000);

                        Console.Clear();
                    }
                    Console.WriteLine("Tu as fini ton travail pour la journée, tu rentres chez toi en retard.");
                    Game.Transition<Retourmaison>();
                    break; 

                case "non":
                    int w = 0;
                    while (w < 10)
                    {
                        Console.WriteLine("Boss : Je comprends, je peux pas t'imposer ça. \n");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int j = 0; j < 10; j++)
                        {
                            if (w == j)
                            {
                                Console.ResetColor();
                            }
                            Console.Write("\u25A0");
                        }
                        Console.ResetColor();
                        Console.WriteLine("]");
                        w++;
                        Thread.Sleep(1000);

                        Console.Clear();
                    }
                    Console.WriteLine("Tu as fini ton travail pour la journée, tu rentres chez toi tôt. ");
                    Game.Transition<Retourmaisondeux>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    Console.WriteLine(choice);
                    break;
            }
        }
    }
}
