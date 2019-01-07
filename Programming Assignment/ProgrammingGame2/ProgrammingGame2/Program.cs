using System;



namespace ProgrammingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE PLAYER
            Player player = new Player(10, 5, new TwoDPoint(50, 50));
            Console.WriteLine("hello, what is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("welcome to the game " + playerName);
            //PRINT PLAYER STATUS
            Console.WriteLine("print player status");

            string playerStatus = Console.ReadLine();

            if(playerStatus == "print player status")
            {
                
                player.printPlayerStatus();
            }

            //CREATE NPC
            Console.WriteLine("type create npc");

            string CreateNPC = Console.ReadLine();

            if (CreateNPC == "create npc")
            {
                //npc 1
                Console.WriteLine("What would you like to call npc1?");
                string npc1Name = Console.ReadLine();
                NPC npc1 = new NPC("MONSTER", "HAVE LARGE FANGS", new TwoDPoint(10, 20),5,npc1Name, "UNKNOWN");
                
                //npc 2
                Console.WriteLine("What would you like to call npc2?");
                string npc2Name = Console.ReadLine();
                NPC npc2 = new NPC("MONSTER", "HAVE A TERRIBLE STENCH", new TwoDPoint(30, 80),5,npc2Name, "UNKNOWN");

                //npc3
                Console.WriteLine("What would you like to call npc3?");
                string npc3Name = Console.ReadLine();
                NPC npc3 = new NPC("ALIEN", "HAVE LOVELY SHOES", new TwoDPoint(50, 50),5,npc3Name, "UNKNOWN");


                //npc 4
                Console.WriteLine("What would you like to call npc4?");
                string npc4Name = Console.ReadLine();
                NPC npc4 = new NPC("MONSTER", "GAVE YOU FRESHLY BAKED COOOKIES", new TwoDPoint(20, 90),5,npc4Name, "UNKNOWN");

                //npc 5
                Console.WriteLine("What would you like to call npc5?");
                string npc5Name = Console.ReadLine();
                NPC npc5 = new NPC("ALIEN", "TOLD YOU A SECRET ABOUT NPC 1. DOESN'T SOUND GOOD", new TwoDPoint(80, 10),5,npc5Name, "UNKNOWN");

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
        protected int playerAmmo;
        protected int playerHP;
        protected TwoDPoint playerPosition;

        public Player(int ammo, int health, TwoDPoint position)
        {
            playerAmmo = ammo;
            playerHP = health;
            playerPosition = position;
        }

        public void printPlayerStatus()
        {
            Console.WriteLine("You have {0} bullets left, your health is {1} and you are at {2),{3) position", playerAmmo, playerHP, playerPosition.x, playerPosition.y);
        }

    }

    public class NPC
    {
        protected string npcType;
        protected string npcBackstory;
        protected TwoDPoint npcPosition;
        protected int npcHP;
        protected string npcName;
        protected string npcStatus;


        public NPC(string type, string backstory, TwoDPoint position, int health,string name, string status)
        {
            npcType = type;
            npcBackstory = backstory;
            npcPosition = position;
            npcHP = health;
            npcName = name;
            npcStatus = status;
        }

        public void printStatus()
        {
            Console.WriteLine("{4} is a {0} they {1} and is at {2},{3} position. {4}'s alliegiance status is {5}", npcType, npcBackstory, npcPosition.x, npcPosition.y,npcName,npcStatus);
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

