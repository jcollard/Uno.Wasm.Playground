public class Launcher
{
    public static void Main() {
        // See https://aka.ms/new-console-template for more information
        CaptainCoder.WebConsole.WebConsole.InitWebConsole().ContinueWith(_ => {
            Execute();
        });
        
    }


    private static void Execute() {
        try {
            Program.Run();
        } catch (Exception e) {
            Console.WriteLine("The program was unable to launch.");
            Console.WriteLine(e);
        }
        // MethodInfo method = program.GetMethod("Main");
        // Console.WriteLine(method);
    }
}