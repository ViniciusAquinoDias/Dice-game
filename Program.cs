void Game(string namePL1,string namePL2)
{
    Random rn = new Random();
    for (byte i = 0; i < 3; i++)
    {
        int[] dice = new int[9];
        int diceP1 = rn.Next(dice.Length);
        int diceP2 = rn.Next(dice.Length);

        if (diceP1 > diceP2)
        {
            Console.WriteLine($"The {namePL1} Win's with most number {diceP1} and the loser get the number {diceP2}");
            Console.ReadKey();
        }
        else if (diceP1 < diceP2)
        {
            Console.WriteLine($"The {namePL2} Win's with most number {diceP2} and the loser get the number {diceP1} ");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"Equal. Nobody win's this round {diceP2}");
            Console.ReadKey();
        }
    }
}

Console.WriteLine("Board Game");
Console.WriteLine("\nRules:\n");
Console.WriteLine("In this game the limit of players are two.\nYou have to put yours name.\nin the dice have's how the most number is 10");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Player one: ");
string namePL1 = Console.ReadLine();

Console.WriteLine("Player two: ");
string namePL2 = Console.ReadLine();
Console.Clear();

Game(namePL1, namePL2);