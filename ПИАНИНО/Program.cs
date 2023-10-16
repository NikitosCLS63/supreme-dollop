
internal class Program
{
    static int[] oneOkt = new int[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
    static int[] tooOkt = new int[12] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
    static int[] destOkt = new int[12];




    static void Main(string[] args)
    {
        Console.WriteLine("F1 и F2 - переключение  октав.");
        Console.WriteLine("С q по u - белые клавиши, с a по g - чёрные.");
        Console.WriteLine("Первая октава.");
        destOkt = oneOkt;
        do
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
            {
                Oktava(key);
            }
            Zvuk(key);
        }
        while (true);
    }
    static int[] Oktava(System.ConsoleKeyInfo key)
    {
        string okt = key.Key == ConsoleKey.F1 ? "Первая октава" : "Вторая октава";
        Console.WriteLine(okt);
        destOkt = key.Key == ConsoleKey.F1 ? oneOkt : tooOkt;
        return destOkt;
    }




    static void Zvuk(System.ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.Q:
                Console.Beep(destOkt[0], 300);
                break;
            case ConsoleKey.W:
                Console.Beep(destOkt[2], 300);
                break;
            case ConsoleKey.E:
                Console.Beep(destOkt[4], 300);
                break;
            case ConsoleKey.R:
                Console.Beep(destOkt[5], 300);
                break;
            case ConsoleKey.T:
                Console.Beep(destOkt[7], 300);
                break;
            case ConsoleKey.Y:
                Console.Beep(destOkt[9], 300);
                break;
            case ConsoleKey.U:
                Console.Beep(destOkt[11], 300);
                break;
            case ConsoleKey.A:
                Console.Beep(destOkt[1], 300);
                break;
            case ConsoleKey.S:
                Console.Beep(destOkt[3], 300);
                break;
            case ConsoleKey.D:
                Console.Beep(destOkt[6], 300);
                break;
            case ConsoleKey.F:
                Console.Beep(destOkt[8], 300);
                break;
            case ConsoleKey.G:
                Console.Beep(destOkt[10], 300);
                break;
        }
    }
}





