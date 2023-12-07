using System.Media;
using ProjetNarratif;
namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal static bool ifhabiller;
        internal override string CreateDescription() =>
@"Tu te réveil au au petit matin en sueur pour une raison que t'ignore.
Bien heureusement tu as ta douce femme Monica à côté de toi. 
Tu décides d'aller dans les [toilettes].
Tu décides d'[enlacer] ta femme.
Tu décides de t'[habiller].
Tu décides d'aller au [salon].
";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "toilettes":
                    Console.WriteLine("Tu entres dans la salle de bain.");
                    Game.Transition<Bathroom>();
                    break;

                case "salon":
                    if (ifhabiller == false)
                    {
                        Console.WriteLine("Monica : chéri habille toi avant.");
                    }
                    else
                    {
                        Console.WriteLine("Tu vas au salon.");
                        Game.Transition<salon>();
                    }
                    break;

                case "enlacer":
                    Console.WriteLine("Monica : Tu es déjà en retard mon amour il va falloir y'aller.");
                    break;

                case "habiller":
                    Console.WriteLine("Tu t'habilles avec ton costumes pour aller au travail.\n" +
                        "Toi : Alors je suis comment ?.\n" +
                        "Monica : Beau comme d'habitude mon amour. ");
                    ifhabiller = true;

                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
