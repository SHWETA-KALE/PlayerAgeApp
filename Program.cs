using System.Numerics;
using PlayerApp.models;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[]
            {
                new Player(101, "A", 29),
                new Player(101, "B", 20),
                new Player(101, "C", 30),
                new Player(101, "D", 34),
                new Player(210, "E")
            };

             Player eldest = Player.WhoIsElder(players);
             Console.WriteLine(eldest);


        }
    }
}
