int points1 = 0;
int points2 = 0;
int games1 = 0;
int games2 = 0;
string Match_Type = "";
int numberOfGames = 0;
int winner = 0;


switch(Match_Type)
{
    case "s" : numberOfGames = 1; break;
    case "r" : numberOfGames = 4; break;
    case "d" : numberOfGames = 3; break;
}

Console.Write("Please choose a match type ( [s]hort, [r]egual, [d]ouble ): ");
Match_Type = Console.ReadLine()!;

do
{
    points1 = 0;
    points2 = 0;
    
    do
    {
        Console.WriteLine("Who has made the point? ");
        winner = int.Parse(Console.ReadLine()!);
        if (winner == 1) {points1 ++;} 
        else if (winner == 2) {points2 ++;}
        Console.WriteLine("Points: " +points1+ ":" + points2);
    } while (points1 < 11 && points2 < 11);

    if (points1 == 11)
    {
        Console.WriteLine("Player 1 wins the game");
        games1++;
    }

    else if (points2 == 11)
    {Console.WriteLine("Player 2 wins the game");
    games2++;
    }
    Console.WriteLine("games: " +games1 + " : " + games2);

} while (games1 < numberOfGames && games2 < numberOfGames);

if (games1 == numberOfGames)
{Console.WriteLine("Player1, You won the game :) ");}
else {Console.WriteLine("Player2, You won the game :) ");}