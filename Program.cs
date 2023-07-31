// Coin Flip
static string CoinFlip() 
{
    Random random = new Random();
    int flip = random.Next(100);
    string result;
    if (flip < 50) 
    {
        result = "heads";
    } 
    else 
    {
        result = "tails";
    }
    return result;
}
Console.WriteLine(CoinFlip());

// Dice Roll - take 2
static int DiceRoll() 
{
    Random random= new Random();
    int result = random.Next(1,7);
    return result;
}
Console.WriteLine(DiceRoll());

// Stat Roll
// static List<int> StatRoll(int rolls)
static int StatRoll(int rolls)
{
    int largestRoll = 0;
    List<int> results = new List<int>();
    for (int i = 0; i < rolls; i++)
    {
        int roll = DiceRoll();
        results.Add(roll);
        if (roll > largestRoll)
        {
            largestRoll = roll;
        }
    }
    Console.WriteLine("Rolls: [{0}]", string.Join(", ",results));
    // return results;
    return largestRoll;
}
Console.WriteLine(StatRoll(4));

// Roll Until...
static int RollUntil()
{
    int rolls = 0;
    int roll = 0;
    while (roll != 6 || rolls >= 100)
    {
        roll = DiceRoll();
        rolls += 1;
    }
    if (rolls >= 100)
    {
        Console.Write("Stopped rolling after:");
    }
    else
    {
        Console.Write("Rolled a 6 after roll ");
    }
    return rolls;
}
Console.WriteLine(RollUntil());

// Dice Roll_beta - wrote this before finished reading instructions -> Optional Bonus
static List<string> DiceRoll_Beta() {
    List<string> rolls = new List<string>();

    Console.WriteLine("How many dice do you want to roll?");
    string Dice = Console.ReadLine();
    if (Int32.TryParse(Dice, out int DiceCount))
    {
        Console.WriteLine("What sides do the dice have?");
        string Die = Console.ReadLine();
        if (Int32.TryParse(Die, out int DieType))
        {
            Random random = new Random();
            for (int i = 1; i <= DiceCount; i++)
            {
                int roll = random.Next(1,DieType+1);
                rolls.Add(roll.ToString());
            }
        } 
        else 
        {
            Console.WriteLine("Please specify using numbers");
        }
    } 
    else 
    {
        Console.WriteLine("Please specify using numbers.");
    }
    return rolls;
}
Console.WriteLine("[{0}]", string.Join(", ",DiceRoll_Beta()));
