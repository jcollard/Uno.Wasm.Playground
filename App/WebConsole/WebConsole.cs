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
        Interop.Runtime.InvokeJS($"write(`{EncodeChar(value)}`)", out int exceptional_result);
    }

    public string EncodeChar(char ch) {
        if (ch == '\n') return "\\n\\r";
        return ch.ToString();
    }
}

public class Thread 
{
    public static async Task Sleep(int millis) => await Task.Delay(millis);
}

public class Console : AbstractWebConsole
{
    private static readonly Console Instance = new Console();

    public static void InitWebConsole() {
        Instance.Clear();
        System.Console.WriteLine("Initializing Web Console");
        System.Console.SetOut(CaptainCoder.WebConsole.WebConsole.Instance.TextWriter);
        Interop.Runtime.InvokeJS($"initWebConsole()", out int _);        
    }
    
    public override async Task<string?> ReadLine() {
         while(bool.Parse(Interop.Runtime.InvokeJS($"isInputBufferEmpty()", out int _)))
         {
            Interop.Runtime.InvokeJS($"blockOnInput()", out int _);
            await Task.Delay(100);
         }
         Interop.Runtime.InvokeJS($"unblockOnInput()", out int _);
        return Interop.Runtime.InvokeJS($"dequeueBuffer()", out int _);
    }

    public override void Clear() {
        Interop.Runtime.InvokeJS($"clear()", out int _);
    }

    // public static async Task<string?> ReadLine() => (await Instance._ReadLine());
}