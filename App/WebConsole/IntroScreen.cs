namespace CaptainCoder.WebConsole;

public static class IntroScreen
{
    public static async Task DisplayIntroScreen()
    {
        WebConsole.Instance.Clear();
        Console.WriteLine(CSHARP_INTRO);
        await WebConsole.Instance.ReadLine();

    }
    private static readonly string CSHARP_INTRO = @"   ____  _  _     _____                   _             _ 
  / ___|| || |_  |_   _|__ _ __ _ __ ___ (_)_ __   __ _| |
 | |  |_  ..  _|   | |/ _ \ '__| '_ ` _ \| | '_ \ / _` | |
 | |__|_      _|   | |  __/ |  | | | | | | | | | | (_| | |
  \____||_||_|     |_|\___|_|  |_| |_| |_|_|_| |_|\__,_|_|
  _____                 _       _
 | ____|_ __ ___  _   _| | __ _| |_ ___  _ __             
 |  _| | '_ ` _ \| | | | |/ _` | __/ _ \| '__|            
 | |___| | | | | | |_| | | (_| | || (_) | |               
 |_____|_| |_| |_|\__,_|_|\__,_|\__\___/|_|               

 C# Terminal Emulator for the Web v0.0.1 by Joseph Collard
 
 Press Enter to Start Program";
}