using System.Text;
using WebAssembly;

namespace CaptainCoder.WebConsole;


public class Thread 
{
    public static async Task Sleep(int millis) => await Task.Delay(millis);
}

public class WebConsole : AbstractWebConsole
{
    
    private static new readonly WebConsole Instance = new ();
    public TextWriter TextWriter { get; } = new WebConsoleTextWriter();

    public static async Task InitWebConsole() {
        Debug("Initializing Web Console");
        string result = Interop.Runtime.InvokeJS($"initWebConsole()", out int _);
        static bool isReady() => bool.Parse(Interop.Runtime.InvokeJS("isReady()", out int _));
        while (!isReady()) {
            Debug("Waiting for Terminal to be ready.");
            await Task.Delay(25);            
        } 
        System.Console.SetOut(Instance.TextWriter);
        Debug("InitWebConsole() Finished.");
    }

    public static void Debug(string message) {
        var ts = DateTime.Now;
        message = $"Debug({ts.ToShortDateString()}@{ts.ToShortTimeString()}): {message}";
        Interop.Runtime.InvokeJS($"console.debug(\"{message}\")", out int _);
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

    public override bool IsInputRedirected => System.Console.IsInputRedirected;

    public override int BufferHeight { 
        get {
            System.Console.WriteLine("ERROR: BufferHeight is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: BufferHeight is not supported in WebConsole");  
        }
    }
    public override int BufferWidth { 
        get {
            System.Console.WriteLine("ERROR: BufferWidth is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: BufferWidth is not supported in WebConsole");  
        }
    }

    public override bool CapsLock {
        get {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
            return default;
        }
    }

    public override int CursorLeft { 
        get {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
        }
    }
    public override int CursorSize { 
        get {
            System.Console.WriteLine("ERROR: CursorSize is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorSize is not supported in WebConsole");  
        }
    }
    public override int CursorTop { 
        get {
            System.Console.WriteLine("ERROR: CursorTop is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorTop is not supported in WebConsole");  
        }
    }
    public override bool CursorVisible { 
        get {
            System.Console.WriteLine("ERROR: CursorVisible is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorVisible is not supported in WebConsole");  
        }
    }

    public override TextWriter Error => System.Console.Error;

    private static readonly ConsoleColor DefaultForegroundColor = ConsoleColor.White;
    private static readonly ConsoleColor DefaultBackgroundColor = ConsoleColor.Black;
    private ConsoleColor _foregroundColor = DefaultForegroundColor;
    private ConsoleColor _backgroundcolor = DefaultBackgroundColor;
    public override ConsoleColor ForegroundColor { 
        get => _foregroundColor;
        set {
            string code = GetColorCode(value);
            _foregroundColor = value;
            // System.Console.WriteLine($"\\x1b[1;31m");
            //\\x1b\xa;[X11 color spec]\a
            System.Console.Write($"\\\x1b[38;2;{code}m");
        }
    }

    private static string GetColorCode(ConsoleColor color) {
        return color switch {
                ConsoleColor.Black => "0;0;0",
                ConsoleColor.Blue => "0;0;255",
                ConsoleColor.Cyan => "0;255;255",
                ConsoleColor.Gray => "200;200;200",
                ConsoleColor.Green => "0;255;0",
                ConsoleColor.Magenta => "255;0;255",
                ConsoleColor.Red => "255;0;0",
                ConsoleColor.Yellow => "255;255;0",

                ConsoleColor.DarkBlue => "0;0;200",
                ConsoleColor.DarkCyan => "0;200;200",
                ConsoleColor.DarkGray => "105;105;105",
                ConsoleColor.DarkGreen => "0;200;0",
                ConsoleColor.DarkMagenta => "200;0;200",
                ConsoleColor.DarkRed => "200;0;0",
                ConsoleColor.DarkYellow => "200;200;0",

                ConsoleColor.White => "255;255;255",
                _ => "30"
            };
    }

    public override ConsoleColor BackgroundColor { 
        get => _backgroundcolor;
        set {
            string code = GetColorCode(value);
            _backgroundcolor = value;
            System.Console.Write($"\\x1b[48;2;{code}m");

        }
    }

    public override TextReader In => System.Console.In;

    public override Encoding InputEncoding { get => System.Console.InputEncoding; set => System.Console.InputEncoding = value; }

    public override bool IsErrorRedirected => System.Console.IsErrorRedirected;

    public override int WindowWidth { 
        get {
            System.Console.WriteLine("ERROR: WindowWidth is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowWidth is not supported in WebConsole");  
        }
    }

    public override bool IsOutputRedirected => System.Console.IsOutputRedirected;

    public override bool KeyAvailable {
        get {
            System.Console.WriteLine("ERROR: KeyAvailable is not supported in WebConsole");  
            return default;
        }
    }

    public override int LargestWindowHeight {
        get {
            System.Console.WriteLine("ERROR: LargestWindowHeight is not supported in WebConsole");  
            return default;
        }
    }

    public override int LargestWindowWidth {
        get {
            System.Console.WriteLine("ERROR: LargestWindowWidth is not supported in WebConsole");  
            return default;
        }
    }

    public override bool NumberLock {
        get {
            System.Console.WriteLine("ERROR: NumberLock is not supported in WebConsole");  
            return default;
        }
    }
    public override TextWriter Out => System.Console.Out;

    public override Encoding OutputEncoding { get => System.Console.OutputEncoding; set => System.Console.OutputEncoding = value; }
    public override string Title { 
        get {
            System.Console.WriteLine("ERROR: Title is not supported in WebConsole");  
            return string.Empty;
        }
        set {
            System.Console.WriteLine("ERROR: Title is not supported in WebConsole");  
        }
    }
    public override bool TreatControlCAsInput { 
        get {
            System.Console.WriteLine("ERROR: TreatControlCAsInput is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: TreatControlCAsInput is not supported in WebConsole");  
        }
    }
    public override int WindowHeight { 
        get {
            System.Console.WriteLine("ERROR: WindowHeight is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowHeight is not supported in WebConsole");  
        }
    }
    public override int WindowLeft { 
        get {
            System.Console.WriteLine("ERROR: WindowLeft is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowLeft is not supported in WebConsole");  
        }
    }
    public override int WindowTop { 
        get {
            System.Console.WriteLine("ERROR: WindowTop is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowTop is not supported in WebConsole");  
        }
    }


    public override event ConsoleCancelEventHandler? CancelKeyPress;

    public override void Beep() => System.Console.WriteLine("ERROR: Beep is not supported in WebConsole"); 

    public override void Beep(int frequency, int duration) => System.Console.WriteLine("ERROR: Beep is not supported in WebConsole"); 

    public override (int Left, int Top) GetCursorPosition()
    {
        System.Console.WriteLine("ERROR: GetCursorPosition is not supported in WebConsole"); 
        return default;
    }

    public override void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
    {
        System.Console.WriteLine("ERROR: MoveBufferArea is not supported in WebConsole"); 
    }

    public override void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
    {
        System.Console.WriteLine("ERROR: MoveBufferArea is not supported in WebConsole"); 
    }

    public override Stream OpenStandardError(int bufferSize) => System.Console.OpenStandardError(bufferSize);

    public override Stream OpenStandardError() => System.Console.OpenStandardError();

    public override Stream OpenStandardInput(int bufferSize) => System.Console.OpenStandardInput(bufferSize);

    public override Stream OpenStandardInput() => System.Console.OpenStandardInput();

    public override Stream OpenStandardOutput(int bufferSize) => System.Console.OpenStandardOutput(bufferSize);

    public override Stream OpenStandardOutput() => System.Console.OpenStandardOutput();

    public override async Task<int> Read()
    { 
        System.Console.WriteLine("ERROR: Read is not supported in WebConsole"); 
        await Task.Delay(0);
        return default; 
    }

    public override async Task<ConsoleKeyInfo> ReadKey(bool intercept)
    { 
        System.Console.WriteLine("ERROR: ReadKey is not supported in WebConsole"); 
        await Task.Delay(0);
        return default; 
    }

    public override async Task<ConsoleKeyInfo> ReadKey() { 
        System.Console.WriteLine("ERROR: ReadKey is not supported in WebConsole"); 
        await Task.Delay(0);
        return default; 
    }

    public override void ResetColor() {
        Console.ForegroundColor = DefaultForegroundColor;
        Console.BackgroundColor = DefaultBackgroundColor;
    }


    public override void SetBufferSize(int width, int height) => System.Console.WriteLine("ERROR: SetBufferSize is not supported in WebConsole");


    public override void SetCursorPosition(int left, int top) => System.Console.WriteLine("ERROR: SetCursorPosition is not supported in WebConsole");

    public override void SetError(TextWriter newError) => System.Console.SetError(newError);
    public override void SetIn(TextReader newIn) => System.Console.WriteLine("ERROR: SetIn is not supported in WebConsole");

    public override void SetOut(TextWriter newOut) => System.Console.SetOut(newOut);

    public override void SetWindowPosition(int left, int top) => System.Console.WriteLine("ERROR: SetWindowPosition is not supported in WebConsole");

    public override void SetWindowSize(int width, int height) => System.Console.WriteLine("ERROR: SetWindowSize is not supported in WebConsole");

    public override void Write(ulong value) => System.Console.Write(value);

    public override void Write(bool value) => System.Console.Write(value);

    public override void Write(char value) => System.Console.Write(value);

    public override void Write(char[]? buffer) => System.Console.Write(buffer);

    public override void Write(int value) => System.Console.Write(value);

    public override void Write(decimal value) => System.Console.Write(value);

    public override void Write(long value) => System.Console.Write(value);

    public override void Write(object? value) => System.Console.Write(value);

    public override void Write(float value) => System.Console.Write(value);

    public override void Write(string? value) => System.Console.Write(value);

    public override void Write(string format, object? arg0) => System.Console.Write(format, arg0);

    public override void Write(string format, object? arg0, object? arg1) => System.Console.Write(format, arg0, arg1);

    public override void Write(string format, object? arg0, object? arg1, object? arg2) => System.Console.Write(format, arg0, arg1, arg2);

    public override void Write(string format, params object?[]? arg) => System.Console.Write(format, arg);

    public override void Write(uint value) => System.Console.Write(value);

    public override void Write(char[] buffer, int index, int count) => System.Console.Write(buffer, index, count);

    public override void Write(double value) => System.Console.Write(value);

    public override void WriteLine(uint value) => System.Console.WriteLine(value);

    public override void WriteLine(string format, params object?[]? arg) => System.Console.WriteLine(format, arg);
    public override void WriteLine() => System.Console.WriteLine();

    public override void WriteLine(bool value) => System.Console.WriteLine(value);

    public override void WriteLine(char[]? buffer) => System.Console.WriteLine(buffer);
    public override void WriteLine(char[] buffer, int index, int count) => System.Console.WriteLine(buffer, index, count);

    public override void WriteLine(decimal value) => System.Console.WriteLine(value);

    public override void WriteLine(double value) => System.Console.WriteLine(value);

    public override void WriteLine(ulong value) => System.Console.WriteLine(value);

    public override void WriteLine(int value) => System.Console.WriteLine(value);

    public override void WriteLine(object? value) => System.Console.WriteLine(value);

    public override void WriteLine(float value) => System.Console.WriteLine(value);

    public override void WriteLine(string? value) => System.Console.WriteLine(value);

    public override void WriteLine(string format, object? arg0) => System.Console.WriteLine(format, arg0);

    public override void WriteLine(string format, object? arg0, object? arg1) => System.Console.WriteLine(format, arg0, arg1);

    public override void WriteLine(string format, object? arg0, object? arg1, object? arg2) => System.Console.WriteLine(format, arg0, arg1, arg2);
    public override void WriteLine(long value) => System.Console.WriteLine(value);

    public override void WriteLine(char value) => System.Console.WriteLine(value);
}


public class WebConsoleTextWriter : TextWriter
{
    public override Encoding Encoding => Encoding.Default;

    public override void Write(char value)
    {
        Interop.Runtime.InvokeJS($"write(`{EncodeChar(value)}`)", out int exceptional_result);
    }

    public override void Write(string? s) => _write(s ?? string.Empty);

    public override void WriteLine(string? s) => Write(s + "\n");

    private void _write(string s) => Interop.Runtime.InvokeJS($"write(`{EncodeString(s ?? string.Empty)}`)", out int exceptional_result);

    public override void WriteLine() {
        Interop.Runtime.InvokeJS($"write(`{EncodeChar('\n')}`)", out int exceptional_result);
    }

    private string EncodeChar(char ch) {
        if (ch == '\n') return "\\n\\r";
        if (ch == '\r') return string.Empty;
        if (ch == '`') return "\\`";
        if (ch == '\\') return "\\\\";
        if (ch == '$') return "\\$";
        return ch.ToString();
    }
    private string EncodeString(string? s) {
        WebConsole.Debug($"Encoding: {s.Length}");
        if (s == null) return string.Empty;
        StringBuilder sb = new StringBuilder();
        foreach(char ch in s)
        {
            sb.Append(EncodeChar(ch));
        }
        return sb.ToString();
    }
}