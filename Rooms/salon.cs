using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class salon : Room
    {
        internal override string CreateDescription() =>
@"Le salon est en bordel c'est normal tu t'es amusé avec ta fille et ta femme hier avant de dormir.
Tu décides d'allumer la [télé].
Tu décides de [ranger] un peu.
Tu décides d'aller dans la [cuisine] pour te faire à manger.
";
        internal override void ReceiveChoice(string choice)
        {      
            switch (choice)
            {
                case "télé":
                    Console.WriteLine("Tu allumes la télé, les news parle de plusieurs meurtes qui sont arrivé dans ta ville.\n" +
                        "News : les victimes sont toutes des femmes, il s'agit surement du fameux Leblanc. Avant de vous couchez vérifier bien que votre porte est fermé à clé.\n" +
                        "Toi : Encore lui ? Les autorités sont vraiment incompétente dans cette ville.");
                    break;

                case "ranger":
                    Console.WriteLine("toi : C'est le bordel ici, mais j'ai pas le temps de ranger je suis à la bourre. ");
                    break;

                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;

                case "cuisine":
                    Console.WriteLine("Tu vas dans la cuisine.");
                    Game.Transition<Cuisine>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
