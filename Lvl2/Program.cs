
int heroHP = 100;
int hpright = 100;

//------------------------------------------------------------------------------
//weapon/attacks stats
int i = Random.Shared.Next(11);

//------------------------------------------------------------------------------

bool retry = true;

//------------------------------------------------------------------------------

Console.WriteLine("Please chose a name");
string name = Console.ReadLine().ToUpper();

Console.WriteLine("Press ENTER to start");
Console.ReadLine();

//------------------------------------------------------------------------------

while (retry == true)
{
    while (heroHP > 1 && hpright > 1)
    {
        hpright -= i;
        Console.WriteLine($"{name} dealt {i} damage to OPPONENT \nOPONENT has {hpright} HP left");
        Console.WriteLine("-----------------------------------------");

        i = Random.Shared.Next(11);

//------------------------------------------------------------------------------

        heroHP -= i;
        Console.WriteLine($"OPPONENT dealt {i} damage to {name} \n{name} has {heroHP} HP left");
        Console.WriteLine("-----------------------------------------");

        i = Random.Shared.Next(11);

        Console.ReadKey();
        Console.Clear();
    }

    if (heroHP < 1 && hpright < 1)
    {
        Console.WriteLine("The fighters knocked eacother out");
    }
    else
    {
        if (heroHP < 1)
        {
            Console.WriteLine(" wins");
        }
        if (hpright < 1)
        {
            Console.WriteLine($"{name} wins");
        }
    }

    //------------------------------------------------------------------------------

    Console.WriteLine("Retry? \nA) Yes \nB) No");
    string retryConfirm = Console.ReadLine().ToLower();

    if (retryConfirm == "a")
    {
        retry = true;
        Console.ReadLine();
    }
    if (retryConfirm == "b")
    {
        retry = false;
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("We'll take that as a no");
        retry = false;
        Console.ReadLine();
    }
}