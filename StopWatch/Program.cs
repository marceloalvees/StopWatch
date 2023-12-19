
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("WELCOME:");
    Console.WriteLine(" S = Seconds => 10s = 10Seconds");
    Console.WriteLine(" M = Minutes => 1m = 1 Minutes");
    Console.WriteLine(" 0 = To go out");
    Console.WriteLine("How long do you want to count?");

    string data = Console.ReadLine().ToLower();
    string type = data.Substring(data.Length - 1);
    int time = int.Parse(data.Substring(0, data.Length - 1));
    if(time == 0)
        System.Environment.Exit(0);

    if (type == "m")
        PreStart(time * 60);
    else
    {
        PreStart(time);
    }
 }

static void PreStart (int time)
{
    Console.Clear();
    Console.WriteLine("Ready.....");
    Thread.Sleep(1000);
    Console.WriteLine("Set.....");
    Thread.Sleep(1000);
    Console.WriteLine("Go.....");
    Thread.Sleep(1000);

    Start(time);
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
    Console.WriteLine("Stop Stopwatch");
    Thread.Sleep(1000);
}