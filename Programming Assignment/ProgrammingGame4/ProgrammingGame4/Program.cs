using System;



namespace ProgrammingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //PLAYER
            int playerHealth = 5;
            int playerAmmo = 10;
            int playerX = 50;
            int playerY = 50;

            //NPC
            string npc1Status = "Unknown";
            string npc2Status = "Unknown";
            string npc3Status = "Unknown";
            string npc4Status = "Unknown";
            string npc5Status = "Unknown";

            int npc1Health = 5;
            int npc2Health = 5;
            int npc3Health = 5;
            int npc4Health = 5;
            int npc5Health = 5;



            //CREATE PLAYER
            Player player = new Player(playerAmmo, playerHealth, new TwoDPoint(playerX, playerY));
            Console.WriteLine("hello, what is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("welcome to the game " + playerName);

            //PRINT PLAYER STATUS
            Console.WriteLine("print player status");

            string playerStatus = Console.ReadLine();
           
            if (playerStatus == "print player status")
            {
                player.printPlayerStatus();

            }

            //MOVE

            Console.WriteLine("move");
            string move = Console.ReadLine();
            
            if(move == "move")
            {
                Console.WriteLine("Enter your updated x value");
                string updateX = Console.ReadLine();
                Console.WriteLine("Enter your updated Y value");
                string updateY = Console.ReadLine();

                int newX = Int32.Parse(updateX);
                int newY = Int32.Parse(updateY);

                playerX = newX;
                playerY = newY;

                Console.WriteLine("Youre new position is {0},{1}",playerX, playerY);
            }

            //CREATE NPC
            Console.WriteLine("type create npc");

            string CreateNPC = Console.ReadLine();

            if (CreateNPC == "create npc")
            {
                //npc 1
                Console.WriteLine("What would you like to call npc1?");
                string npc1Name = Console.ReadLine();
                NPC npc1 = new NPC("MONSTER", "HAS LARGE FANGS", new TwoDPoint(10, 20), npc1Health, npc1Name, npc1Status,true);

                //npc 2
                Console.WriteLine("What would you like to call npc2?");
                string npc2Name = Console.ReadLine();
                NPC npc2 = new NPC("MONSTER", "HAS A TERRIBLE STENCH", new TwoDPoint(30, 80), npc2Health, npc2Name, npc2Status, true);

                //npc3
                Console.WriteLine("What would you like to call npc3?");
                string npc3Name = Console.ReadLine();
                NPC npc3 = new NPC("ALIEN", "HAS LOVELY SHOES", new TwoDPoint(50, 50), npc3Health, npc3Name, npc3Status, false);


                //npc 4
                Console.WriteLine("What would you like to call npc4?");
                string npc4Name = Console.ReadLine();
                NPC npc4 = new NPC("MONSTER", "GAVE YOU FRESHLY BAKED COOOKIES", new TwoDPoint(20, 90), npc4Health, npc4Name, npc4Status, true);

                //npc 5
                Console.WriteLine("What would you like to call npc5?");
                string npc5Name = Console.ReadLine();
                NPC npc5 = new NPC("ALIEN", "TOLD YOU A SECRET ABOUT NPC 1. DOESN'T SOUND GOOD", new TwoDPoint(80, 10), npc5Health, npc5Name, npc5Status, false);

                //PRINT NPC STATUS
                Console.WriteLine("print npc status");

                string printNPCStatus = Console.ReadLine();

                if (printNPCStatus == "print npc status")
                {
                    npc1.printStatus();
                    npc2.printStatus();
                    npc3.printStatus();
                    npc4.printStatus();
                    npc5.printStatus();

                }

                //QUERY NPC
                Console.WriteLine("query npc");
                string query = Console.ReadLine();

                if (query == "query npc")
                {
                    Console.WriteLine("please enter the name of the npc you would like to query");

                    string nameEntered = Console.ReadLine();

                    if (nameEntered == npc1Name)
                    {
                        npc1.queryNPC();
                        
                    }
                    else if (nameEntered == npc2Name)
                    {
                        npc2.queryNPC();
                        
                    }
                    else if (nameEntered == npc3Name)
                    {
                        npc3.queryNPC();
                    }
                    else if (nameEntered == npc4Name)
                    {
                        npc4.queryNPC();
                        
                    }
                    else if (nameEntered == npc5Name)
                    {
                        npc5.queryNPC();
                    }
                }

                //REQUEST ALLIANCE
                Console.WriteLine("request alliance");
                string request = Console.ReadLine();
                
                if(request == "request alliance")
                {
                  Console.WriteLine("please enter an npc that you would like to create an alliane with");
                    string npcRequested = Console.ReadLine(); 

                    if(npcRequested == npc1Name) //Enemy
                    {
                        npc1.RequestAlliance();
                        //Player's health is reduced by 2
                        playerHealth = playerHealth - 2;
                        //Prints players updated health
                        Console.WriteLine("your HP has been reduced by two you now have {0} HP", playerHealth);

                        //Could not change the npcStatus string without using the Sting.Replace method, so it stays as 'Unknown' when npc.printStatus is called
                        npc1Status = "Enemy";

                        //String.Replace method
                        var replace = npc4Status.Replace("Unknown", "Enemy"); //Replacing 'Unknown' with 'Enemy'
                        Console.WriteLine("{0} is now your {1}", npc1Name, replace);
                    }
                    if (npcRequested == npc2Name) //Enemy
                    {
                        npc2.RequestAlliance();
                        playerHealth = playerHealth - 2;
                        Console.WriteLine("your HP has been reduced by two you now have {0} HP", playerHealth);
                        npc2Status = "Enemy";

                        var replace = npc4Status.Replace("Unknown", "Enemy");
                        Console.WriteLine("{0} is now your {1}", npc2Name, replace);
                    }
                    if (npcRequested == npc3Name) //Friend
                    {
                        npc3.RequestAlliance();
                        //Player's health is not affected
                        npc3Status = "Friend";

                        var replace = npc4Status.Replace("Unknown", "Friend");
                        Console.WriteLine("{0} is now your {1}", npc3Name, replace);
                    }
                    if (npcRequested == npc4Name) // Enemy
                    {
                        npc4.RequestAlliance();
                        playerHealth = playerHealth - 2;
                        Console.WriteLine("your HP has been reduced by two you now have {0} HP", playerHealth);
                       
                        var replace = npc4Status.Replace("Unknown","Enemy");
                        Console.WriteLine("{0} is now your {1}",npc4Name,replace);
                    }
                    if (npcRequested == npc5Name) // Friend
                    {
                        npc5.RequestAlliance();
                        
                        npc5Status = "Friend";
                        
                        var replace = npc4Status.Replace("Unknown", "Friend");
                        Console.WriteLine("{0} is now your {1}", npc3Name, replace);
                    }
                }

                //SHOOT
                Console.WriteLine("shoot");
                string shoot = Console.ReadLine();

                if(shoot == "shoot")
                {
                    Console.WriteLine("please enter the name of the npc you would like to shoot");
                    string shootTarget = Console.ReadLine();

                    if(shootTarget == npc1Name) //enemy
                    {
                        
                        npc1Health = npc1Health - 1;
                        playerAmmo = playerAmmo - 1;
                        Console.WriteLine("{0} is an enemy! You shot {0}. {0} has {1} health remaining", npc1Name, playerHealth);
                        Console.WriteLine("You have {0} bullets left", playerAmmo);
                    }
                    else if (shootTarget == npc2Name) //enemy
                    {
                        npc2Health = npc2Health - 1;
                        playerAmmo = playerAmmo - 1;
                        Console.WriteLine("{0} is an enemy! You shot {0}. {0} has {1} health remaining", npc2Name, playerHealth);
                        Console.WriteLine("You have {0} bullets left", playerAmmo);
                    }
                    else if (shootTarget == npc3Name) //friend
                    {
                        playerHealth = playerHealth - 2;
                        playerAmmo = playerAmmo - 1;
                        Console.WriteLine("This npc is not an enemy, your health has been reduced by 2. Your health is now {0}", playerHealth);
                        Console.WriteLine("You have {0} bullets left", playerAmmo);
                    }
                    else if (shootTarget == npc4Name) //enemy
                    {
                        npc4Health = npc4Health - 1;
                        playerAmmo = playerAmmo - 1;
                        Console.WriteLine("{0} is an enemy! You shot {0}. {0} has {1} health remaining", npc4Name, playerHealth);
                        Console.WriteLine("You have {0} bullets left", playerAmmo);
                    }
                    else if (shootTarget == npc5Name) //friend
                    {
                        playerHealth = playerHealth - 2;
                        playerAmmo = playerAmmo - 1;
                        Console.WriteLine("This npc is not an enemy, your health has been reduced by 2. Your health is now {0}", playerHealth);
                        Console.WriteLine("You have {0} bullets left", playerAmmo);
                    }
                }
               
            }

            Console.ReadLine();
        }

    }
    //PLAYER CLASS
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
            Console.WriteLine("You have {0} bullets left, your health is {1} and you are at {2},{3}", playerAmmo, playerHP,playerPosition.x, playerPosition.y);
        }

        public void minusHealth()
        {
            playerHP = playerHP - 2;
        }

        public void Move()
        {
            Console.WriteLine("Enter your updated x value");
        }

    }

    //NPC CLASS
    public class NPC
    {
        protected string npcType;
        protected string npcBackstory;
        protected TwoDPoint npcPosition;
        protected int npcHP;
        protected string npcName;
        protected string npcStatus;
        protected bool npcEnemy;


        public NPC(string type, string backstory, TwoDPoint position, int health, string name, string status,bool enemy )
        {
            npcType = type;
            npcBackstory = backstory;
            npcPosition = position;
            npcHP = health;
            npcName = name;
            npcStatus = status;
            npcEnemy = enemy;
        }

        public void printStatus()
        {
            Console.WriteLine("{4} is a {0} they {1} and is at {2},{3} position. {4}'s alliegiance status is {5}", npcType, npcBackstory, npcPosition.x, npcPosition.y, npcName, npcStatus);
        }

        public void queryNPC()
        {
            Console.WriteLine("{0} {1}", npcName, npcBackstory);
        }

        public void RequestAlliance()
        {
            if (npcEnemy == false)
            {
                Console.WriteLine("{0} is friendly and is now your ally.", npcName);
            }

            else
            {
                Console.WriteLine("{0} attacks you! {0} is now your enemy.", npcName);
                
            }
        }
    }
    //TWO POINTS ON THE GRID CLASS
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
