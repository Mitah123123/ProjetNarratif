using System;
using ProjetNarratif.Rooms;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms;

internal class Retourmaisondeux : Room
{
    internal override string CreateDescription() =>
@"
Tu décides d'aller voir ta [fille].
Tu décides d'aller voir ta [femme].
";
    internal override void ReceiveChoice(string choice)
    {
        switch (choice)
        {
            case "fille":
                {
                    Console.WriteLine("Tu déposes ton sac sur une chaise et tu montes les escaliers qui grincent...un à un...\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Toi : il fait froid. \n");
                    Thread.Sleep(3000);
                    Console.WriteLine("Tu es à l'étage et tu appércois la chambre de ta fille...la porte entre-ouverte.\n");
                    Thread.Sleep(3000);
                    Console.WriteLine("Toi : Ellie c'est papa...tiens c'est bizarre elle répond pas.\n");
                    Thread.Sleep(3000);
                    Console.WriteLine("Tu approches de la sombre chambre petit à petit te disant qu'elle doit sûrement dormir car il est tard.\n");
                    Console.WriteLine("Tu rentres dans la chambre, tu apperçois ta famille, entrain de dormir...");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine("...Elles sont couchées\n");
                    Console.ResetColor();
                    Game.Finish();
                }
                break;

            case "femme":
                {
                    Console.WriteLine("Toi : Chérie je suis rentré.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Toi : Allô...Monica.\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Tu te diriges vers la chambre à coucher.\n");
                    Thread.Sleep(2000);
                    Console.WriteLine("Tu vois des taches de chocolat sur la canapé et une pensée survient et ne quitte plus ta tête. ");
                    Thread.Sleep(3000);
                    Console.WriteLine("Tu commences à marcher de plus en plus rapidement.\n");
                    Console.WriteLine("Tu rentres dans la chambre, tu apperçois ta famille...");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine(".");
                    Thread.Sleep(2000);
                    Console.WriteLine("...Elles sont entrin de regarder un film sans toi.\n");
                    Console.ResetColor();
                    Game.Finish();
                }
                break;
        }
    }
}
