using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{

    internal class Devinette : Room
    {
        internal override string CreateDescription() =>
@"Je suis un félin, qui suis-je ?
";
        internal override void ReceiveChoice(string choice)
        {
            bool devinette;
            string Choix;
            string bonneréponse = "léopard";
            int i = 0 ;
            string réponses = " ";

            for (i = 0;  i <= 3; i++) 
            {
                réponses = Convert.ToString(Console.ReadLine());
                if (réponses == bonneréponse)
                {
                    Console.WriteLine("Ellie : BRAVO PAPA !!!!! ");
                    goto ici1;
                }

                if (réponses != bonneréponse && i == 1)
                {
                    Console.WriteLine("Ellie : Mauvaise réponse papa...il a un pelage tacheté.");
                }

                if (réponses != bonneréponse && i == 2)
                {
                    Console.WriteLine("Ellie : Encore une mauvaise réponse papa... il se trouve en afrique.");
                }

                if (réponses != bonneréponse && i == 3 )
                {
                    Console.WriteLine("Ellie : C'etait le léopard papa !! T'es trop nul.");
                }
            }
            ici1:
            Console.ReadKey();
        }
    }
}