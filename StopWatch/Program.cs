Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length -1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));


    switch (type.ToString())
    {
        case "s":
            Console.WriteLine("Segundos");
            Start(time);
            break;
        case "m":
            Console.WriteLine("Minutos");
            Start(time * 60);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Menu();
}

static void Start(int time)
{
    int currentTime = 0;
    
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    
    Console.Clear();
    Thread.Sleep(2500);
    Console.WriteLine("StopWatch finalizado.");
    Thread.Sleep(2000);
}
