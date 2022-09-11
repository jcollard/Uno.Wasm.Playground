using System.Text;
using WebAssembly;

namespace CaptainCoder.WebConsole;

public class WebConsole
{

    public static WebConsole Instance { get; } = new WebConsole();

    public TextWriter TextWriter { get; } = new WebConsoleTextWriter();
    
}

public class WebConsoleTextWriter : TextWriter
{
    public Queue<char> Buffer { get; } = new ();
    public override Encoding Encoding => Encoding.Default;

    public override void Write(char value)
    {
        Buffer.Enqueue(value);
        Interop.Runtime.InvokeJS($"write(`{value}`)", out int exceptional_result);
    }
}

public class Thread 
{
    public static async Task Sleep(int millis) => await Task.Delay(millis);
}

public class Console 
{
    private static readonly Console Instance = new Console();
    
    private async Task<string?> _ReadLine() {
         while(bool.Parse(Interop.Runtime.InvokeJS($"isInputBufferEmpty()", out int _)))
         {
            Interop.Runtime.InvokeJS($"blockOnInput()", out int _);
            await Task.Delay(100);
         }
         Interop.Runtime.InvokeJS($"unblockOnInput()", out int _);
        return Interop.Runtime.InvokeJS($"dequeueBuffer()", out int _);
    }

    public static void Clear() => Interop.Runtime.InvokeJS($"clear()", out int _);

    public static async Task<string?> ReadLine() => (await Instance._ReadLine());
}