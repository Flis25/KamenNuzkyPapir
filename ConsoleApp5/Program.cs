using Spectre.Console;

AnsiConsole.Write(
    new FigletText("KÁMEN NŮŽKY PAPÍR !")
        .Centered()
        .Color(Color.Red));
Console.ResetColor();
Console.WriteLine("HRÁČ 1 [NOT READY] (zmáčnki cokoliv ke startu)");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Hráč 1 [READY]");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Čekejte prosím");
Console.Clear();
Console.WriteLine(2);
Thread.Sleep(1500);
Console.Clear();
Console.WriteLine(1);
Thread.Sleep(1500);
Console.Clear();

int hrac1 = 0;
int hrac2 = 0;
bool ne = true;

while (ne == true)
{
    Console.WriteLine("Vyber si mezi kámen (1) , nůžky (2) , papír (3)");
    string slovo = Console.ReadLine();
    if (slovo == "1")
    {
        Console.WriteLine("Zvolil si kámen.");
        Random random = new Random();
        int ai = random.Next(1, 4);
        if (ai == 1)
        {
            Console.WriteLine("Tvůj oponent zvolil kámen");
            Console.WriteLine("REMÍZA");
        }
        else if (ai == 2)
        {
            Console.WriteLine("Tvůj oponent zvolil nůžky");
            Console.WriteLine("VYHRÁVÁŠ");
            hrac1 = hrac1 + 1;
        }
        else if (ai == 3)
        {
            Console.WriteLine("Tvůj oponent zvolil papír");
            Console.WriteLine("PROHRÁLS");
            hrac2 = hrac2 + 1;
        }
    }
    else if (slovo == "2")
    {
        Console.WriteLine("Zvolil si nůžky.");
        Random random = new Random();
        int ai = random.Next(1, 4);
        if (ai == 1)
        {
            Console.WriteLine("Tvůj oponent zvolil kámen");
            Console.WriteLine("PROHRÁLS");
            hrac2 = hrac2 + 1;
        }
        else if (ai == 2)
        {
            Console.WriteLine("Tvůj oponent zvolil nůžky");
            Console.WriteLine("REMÍZA");
            Console.WriteLine("Zvítězil si nad oponentem.");
            Console.WriteLine("Chceš hrát znovu? (ano) (ne)");
            ne = false;
            string moznost = Console.ReadLine();
            moznost = moznost.ToLower();
            if (moznost == "ano")
            {
                ne = true;
                hrac1 = 0;
                hrac2 = 0;
                Console.Clear();
        }
            else
            {
                ne = false;
                Console.Clear();
            }
        }
        else if (ai == 3)
        {
            Console.WriteLine("Tvůj oponent zvolil papír");
            Console.WriteLine("VYHRÁVÁŠ");
            hrac1 = hrac1 + 1;
            Console.WriteLine("Prohrál si nad oponentem.");
            Console.WriteLine("Chceš hrát znovu? (ano) (ne)");
            ne = false;
            string moznost = Console.ReadLine();
            moznost = moznost.ToLower();
            if (moznost == "ano")
            {
                ne = true;
                hrac1 = 0;
                hrac2 = 0;
                Console.Clear();
            }
            else
            {
                ne = false;
                Console.Clear();
        }
    }
    }
    else if (slovo == "3")
    {
        Console.WriteLine("Zvolil si papír.");
        Random random = new Random();
        int ai = random.Next(1, 4);
        if (ai == 1)
        {
            Console.WriteLine("Tvůj oponent zvolil kámen");
            Console.WriteLine("VYHRÁVÁŠ");
            hrac1 = hrac1 + 1;
        }
        else if (ai == 2)
        {
            Console.WriteLine("Tvůj oponent zvolil nůžky");
            Console.WriteLine("PROHRÁLS");
            hrac2 = hrac2 + 1;
            Console.WriteLine("Dobrá tedy... Stačí zmáčknout klávesu... a je to. Do toho.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("ZLEJ SI !");
                Thread.Sleep(25);
                Console.WriteLine("ŠPÍNO !");
                Thread.Sleep(25);
            }
        }
        else if (ai == 3)
        {
            Console.WriteLine("Tvůj oponent zvolil papír");
            Console.WriteLine("REMÍZA");
        }
    }
    AnsiConsole.Write(new BarChart()
        .Width(20)
        .Label("[green bold underline]body[/]")
        .CenterLabel()
        .AddItem("TY", hrac1, Color.Red)
        .AddItem("OPONENT", hrac2, Color.Blue1));
    Thread.Sleep(2222);
    Console.ResetColor();
    Console.Clear();
    if (hrac1 == 5)
    {
        Console.WriteLine("Zvítězil si nad oponentem.");
        Console.WriteLine("Chceš pokračovat? (ano) (ne)");
        ne = false;
        string moznost = Console.ReadLine();
        if (moznost == "ano")
        {
            ne = true;
            hrac1 = 0;
            hrac2 = 0;
            Console.Clear();
        }
    }
    else if (hrac2 == 5)
    {
        Console.WriteLine("Prohrál si nad oponentem.");
        Console.WriteLine("Chceš pokračovat? (ano) (ne)");
        ne = false;
        string moznost = Console.ReadLine();
        if (moznost == "ano")
        {
            ne = true;
            hrac1 = 0;
            hrac2 = 0;
            Console.Clear();
        }
    }
}