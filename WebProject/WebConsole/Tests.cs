public static class Tests {

    public static async Task ColorTest() {
        Console.Clear();

        TestColors(ConsoleColor.Black, ConsoleColor.White);
        TestColors(ConsoleColor.Blue, ConsoleColor.Red);
        TestColors(ConsoleColor.DarkBlue, ConsoleColor.DarkRed);
        TestColors(ConsoleColor.Cyan, ConsoleColor.Magenta);
        TestColors(ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta);
        TestColors(ConsoleColor.Gray, ConsoleColor.DarkGray);
        TestColors(ConsoleColor.Green, ConsoleColor.Yellow);
        TestColors(ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
        
        Console.ResetColor();
        Console.WriteLine("Press any key to continue.");
        await Console.ReadLine();
        Console.Clear();
    }

    private static void TestColors(ConsoleColor fore, ConsoleColor back)
    {
        Console.ForegroundColor = fore;
        Console.BackgroundColor = back;
        Console.WriteLine($"{Enum.GetName(fore)} on {Enum.GetName(back)}");
        Console.ForegroundColor = back;
        Console.BackgroundColor = fore;
        Console.WriteLine($"{Enum.GetName(back)} on {Enum.GetName(fore)}");
    }
}