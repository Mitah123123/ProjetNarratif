using ProjetNarratif;
using ProjetNarratif.Rooms;
using System.Diagnostics;
using System.Media;
using NAudio.Wave;

var game = new Game();
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new Travail());
game.Add(new salon());
game.Add(new Cuisine());
game.Add(new Retourmaison());
game.Add(new Retourmaisondeux());


while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("À suivre..");
Console.ReadLine();
