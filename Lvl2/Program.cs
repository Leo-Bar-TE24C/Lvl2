
int heroHP = 100;
int hpright = 100;

//------------------------------------------------------------------------------
//weapon/attacks stats
int CritChance = Random.Shared.Next(1, 101);

int enemyDMG = Random.Shared.Next(7, 9);

bool handsOnly = true;
int throwHands = Random.Shared.Next(3,6);
int handCount = Random.Shared.Next(1, 5);
int allTheHands = Random.Shared.Next(1, 2001);

bool swordHave = false;
int swordDMG = Random.Shared.Next(7, 9);


bool axeHave = false;
int axeBigDMG = Random.Shared.Next(20, 26);
int axeSmallDMG = Random.Shared.Next(1, 5);
int axebigDMGChance = Random.Shared.Next(1, 11);

bool shieldHave = false;

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
    heroHP = 100;
    hpright = 100;

    while (heroHP > 1 && hpright > 1)
    {
        if (handsOnly == true)
        {
            while (handCount > 0)
            {
                hpright -= throwHands;
                Console.WriteLine($"{name} dealt {throwHands} damage to OPPONENT \nOPONENT has {hpright} HP left");
                Console.WriteLine("-----------------------------------------");

                throwHands = Random.Shared.Next(3, 6);
                handCount -= 1;
            }
            handCount = Random.Shared.Next(1, 5);
        }


        //------------------------------------------------------------------------------

        heroHP -= enemyDMG;
        Console.WriteLine($"OPPONENT dealt {enemyDMG} damage to {name} \n{name} has {heroHP} HP left");
        Console.WriteLine("-----------------------------------------");

        enemyDMG = Random.Shared.Next(11);

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
    }
    if (retryConfirm == "b")
    {
        retry = false;
    }
    if (retryConfirm != "a" && retryConfirm != "b")
    {
        Console.WriteLine("We'll take that as a no");
        retry = false;
        Console.ReadLine();
    }
}