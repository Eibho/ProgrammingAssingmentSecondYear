
using System;

// This example code shows how you could implement the required main function for a 
// Console UWP Application. You can replace all the code inside Main with your own custom code.

// You should also change the Alias value in the AppExecutionAlias Extension in the 
// Package.appxmanifest to a value that you define. To edit this file manually, right-click
// it in Solution Explorer and select View Code, or open it with the XML Editor.

namespace ProgrammingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE PLAYER
            Console.WriteLine("hello, what is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("welcome to the game " + playerName);

            Console.WriteLine("type create npc");

            string CreateNPC = Console.ReadLine();

            if (CreateNPC == "create npc")
            {
                NPC npc1 = new NPC("MONSTER", "HAVE LARGE FANGS", new TwoDPoint(10, 20));
                NPC npc2 = new NPC("MONSTER", "HAVE A TERRIBLE STENCH", new TwoDPoint(30, 80));
                NPC npc3 = new NPC("ALIEN", "HAVE LOVELY SHOES", new TwoDPoint(50, 50));
                NPC npc4 = new NPC("MONSTER", "GAVE YOU FRESHLY BAKED COOOKIES", new TwoDPoint(20, 90));
                NPC npc5 = new NPC("ALIEN", "TOLD YOU A SECRET ABOUT NPC 1. DOESN'T SOUND GOOD", new TwoDPoint(80, 10));

                Console.WriteLine("print status");

                string printNPCStatus = Console.ReadLine();

                if (printNPCStatus == "print status")
                {
                    npc1.printStatus();
                    npc2.printStatus();
                    npc3.printStatus();
                    npc4.printStatus();
                    npc5.printStatus();

                }
            }

            Console.ReadLine();
        }

    }
    public class Player
    {

    }

    public class NPC
    {
        protected string npcType;
        protected string npcBackstory;
        protected TwoDPoint npcPosition;


        public NPC(string type, string backstory, TwoDPoint position)
        {
            npcType = type;
            npcBackstory = backstory;
            npcPosition = position;
        }

        public void printStatus()
        {
            Console.WriteLine("This NPC is a {0} they {1} and is at {2},{3} position", npcType, npcBackstory, npcPosition.x, npcPosition.y);
        }
    }

    public struct TwoDPoint
    {

        public int x;
        public int y;


        public TwoDPoint(int p1, int p2)
        {
            x = p1;
            y = p2;

        }
    }
}
