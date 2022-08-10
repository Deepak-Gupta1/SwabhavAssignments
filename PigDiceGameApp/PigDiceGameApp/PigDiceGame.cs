using System;
namespace PigDiceGameApp
{
    internal class PigDiceGame
    {
        static void Main(string[] args)
        {
            int playeroneroll = 0;
            int playertworoll = 0;
            int playerOnetotal;
            int playertwototal;
            int player1gamep=0;
            int player2gamep=0;
            int turn= 0;
            Console.WriteLine("Welcome to PIG DICE GAME !!\nTwo player game.\nGame Rules :\nEach turn player can roll and hold dice untill the roll dice is ONE which end and give zero points for that turn.");
            Console.WriteLine("To win game player have to score 20 points.");
            Console.Write("Player 1 Name: ");
            string player1 =Console.ReadLine();
            Console.Write("Player 2 Name: ");
            string player2 = Console.ReadLine();
            while (player1gamep <=20 && player2gamep <=20)
            {
                turn++;
                Console.WriteLine("\nTURN " + turn); 
                playerOnetotal = 0;
                Console.WriteLine("     " + player1 + " play");
                while (true)
                {
                    Console.Write("" + player1 + " What do you want, Roll or Hold ?(r/h): ");
                    String ch = Console.ReadLine();
                    if (ch == "r")
                    {
                        playeroneroll = Roll();
                        Console.WriteLine("Die: " + playeroneroll);
                        playerOnetotal += playeroneroll;
                    }
                    if (ch == "h")
                    {
                        Console.WriteLine("Score of this Turn is :" + playerOnetotal);
                        break;

                    }
                    else if (playeroneroll == 1)
                    {
                        playerOnetotal = 0;
                        Console.WriteLine("Score of this Turn is :" + playerOnetotal);
                        Console.WriteLine("Turn over.");
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }
                player1gamep += playerOnetotal;

                Console.WriteLine("Total score of "+player1 +" is :" + player1gamep);
                if (player1gamep >=20)
                {
                    break;
                }
                Console.WriteLine("it's time for "+player2 +" to play");


                playertwototal = 0;
                Console.WriteLine("     " + player2 + " play");
                while (true)
                {
                    Console.Write("" + player2 + " What do you want, Roll or Hold ? (r / h) : ");
                    String ch = Console.ReadLine();
                    if (ch == "r")
                    {
                        playertworoll = Roll();
                        Console.WriteLine("Die: " + playertworoll);
                    }
                    if (ch == "h")
                    {
                        Console.WriteLine("Score of this Turn is :" + playertwototal);
                        break;

                    }
                    else if (playertworoll == 1)
                    {
                        playertwototal = 0;
                        Console.WriteLine("Score of this Turn is :" + playertwototal);
                        Console.WriteLine("Turn over.");
                        break;
                    }
                    else
                    {
                        playertwototal += playertworoll;
                        continue;
                    }
                }
                player2gamep += playertwototal;
                Console.WriteLine("Total score of " + player2 + " is  :" + player2gamep);
                if (player2gamep >= 20)
                {
                    break;
                }
            }
            Console.WriteLine("\nGAME OVER");
            Console.WriteLine("Total score of " + player1 + " is  :" + player1gamep +" points and turn required "+turn);
            Console.WriteLine("Total score of " + player2 + " is  :" + player2gamep +" points and turn required " + turn);
            if (player1gamep > player2gamep)
            {
                Console.WriteLine("Congretulation !! " + player1 + "Win The Game.");
            }
            else
            {
                Console.WriteLine("Congretulation !! " + player2 + "Win The Game.");
            }

            Console.ReadKey();
        }
        static int Roll()
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 7);
            return val;
        }
    }
}

