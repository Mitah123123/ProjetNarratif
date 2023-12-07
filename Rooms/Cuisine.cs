using System.ComponentModel.Design;
using System.Drawing;

namespace ProjetNarratif.Rooms
{
    internal class Cuisine : Room
    {
        internal static bool ifmanger;
        internal override string CreateDescription() =>
@"Tu décides de faire à [manger].
Tu décides de partir [travailler].
Ta fille te pose une [devinette].
";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "manger":
                    Console.WriteLine("Tu fais un bon petit déjeuner copieux à ta femme à ta fille et toi.\n" +
                        "Ellie : PAPA !!!!!!! \n" +
                        "Toi : Bonjour princesse comment vas-tu ? \n" +
                        "Ellie : BIENNNNNN \n" +
                        "Monica : Ellie aller viens t'assoir. \n" +
                        "Toi : Monica... ça te dis d'aller tous ensemble à Venise?..\n" +
                        "Monica : Euh ??? on peut se le permettre ? \n" +
                        "Toi : Oui peut être bien si d'ici la fin du mois si je fais quelques heures de plus.\n" +
                        "Monica : OUI !!! avec plaisir chéri, mais ne force pas trop d'accord mon amour. ");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nVous mangez tous ensemble.\n ");
                    Console.ResetColor();
                    Console.WriteLine("Monica : Ellie aller pas de temps à perdre on est en retard pour l'école et papa aussi est en retard.\n" +
                        "Toi : Princesse, tu veux des pommes ou des bananes pour ton lunch.\n" +
                        "Ellie: DES POMMES !!\n");
                    ifmanger = true;

                    break;

                case "travailler":
                    if (ifmanger == true)
                    {
                        Console.WriteLine("Tu pars travailler. ");
                        Game.Transition<Travail>();
                    }
                    else
                    {
                        Console.WriteLine("Je dois faire à manger pour tout le monde.");
                    }
                    break;

                case "devinette":
                    Game.Transition<Devinette>();
                    break;
            }

        }
    }
}