using System.Text;
using CaptainCoder.WebConsole;

public static class Console
{
    public static bool IsInputRedirected => System.Console.IsInputRedirected;

    public static int BufferHeight { 
        get {
            System.Console.WriteLine("ERROR: BufferHeight is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: BufferHeight is not supported in WebConsole");  
        }
    }
    public static int BufferWidth { 
        get {
            System.Console.WriteLine("ERROR: BufferWidth is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: BufferWidth is not supported in WebConsole");  
        }
    }

    public static bool CapsLock {
        get {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
            return default;
        }
    }

    public static int CursorLeft { 
        get {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorLeft is not supported in WebConsole");  
        }
    }
    public static int CursorSize { 
        get {
            System.Console.WriteLine("ERROR: CursorSize is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorSize is not supported in WebConsole");  
        }
    }
    public static int CursorTop { 
        get {
            System.Console.WriteLine("ERROR: CursorTop is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorTop is not supported in WebConsole");  
        }
    }
    public static bool CursorVisible { 
        get {
            System.Console.WriteLine("ERROR: CursorVisible is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: CursorVisible is not supported in WebConsole");  
        }
    }

    public static TextWriter Error => System.Console.Error;

    public static ConsoleColor ForegroundColor { 
        get {
            System.Console.WriteLine("ERROR: ForegroundColor is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: ForegroundColor is not supported in WebConsole");  
        }
    }

    public static TextReader In => System.Console.In;

    public static Encoding InputEncoding { get => System.Console.InputEncoding; set => System.Console.InputEncoding = value; }

    public static bool IsErrorRedirected => System.Console.IsErrorRedirected;

    public static int WindowWidth { 
        get {
            System.Console.WriteLine("ERROR: WindowWidth is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowWidth is not supported in WebConsole");  
        }
    }

    public static bool IsOutputRedirected => System.Console.IsOutputRedirected;

    public static bool KeyAvailable {
        get {
            System.Console.WriteLine("ERROR: KeyAvailable is not supported in WebConsole");  
            return default;
        }
    }

    public static int LargestWindowHeight {
        get {
            System.Console.WriteLine("ERROR: LargestWindowHeight is not supported in WebConsole");  
            return default;
        }
    }

    public static int LargestWindowWidth {
        get {
            System.Console.WriteLine("ERROR: LargestWindowWidth is not supported in WebConsole");  
            return default;
        }
    }

    public static bool NumberLock {
        get {
            System.Console.WriteLine("ERROR: NumberLock is not supported in WebConsole");  
            return default;
        }
    }
    public static TextWriter Out => System.Console.Out;

    public static Encoding OutputEncoding { get => System.Console.OutputEncoding; set => System.Console.OutputEncoding = value; }
    public static string Title { 
        get {
            System.Console.WriteLine("ERROR: Title is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: Title is not supported in WebConsole");  
        }
    }
    public static bool TreatControlCAsInput { 
        get {
            System.Console.WriteLine("ERROR: TreatControlCAsInput is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: TreatControlCAsInput is not supported in WebConsole");  
        }
    }
    public static int WindowHeight { 
        get {
            System.Console.WriteLine("ERROR: WindowHeight is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowHeight is not supported in WebConsole");  
        }
    }
    public static int WindowLeft { 
        get {
            System.Console.WriteLine("ERROR: WindowLeft is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowLeft is not supported in WebConsole");  
        }
    }
    public static int WindowTop { 
        get {
            System.Console.WriteLine("ERROR: WindowTop is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: WindowTop is not supported in WebConsole");  
        }
    }
    public static ConsoleColor BackgroundColor { 
        get {
            System.Console.WriteLine("ERROR: BackgroundColor is not supported in WebConsole");  
            return default;
        }
        set {
            System.Console.WriteLine("ERROR: BackgroundColor is not supported in WebConsole");  
        }
    }

    public static event ConsoleCancelEventHandler? CancelKeyPress;

    public static void Beep() => System.Console.WriteLine("ERROR: Beep is not supported in WebConsole"); 

    public static void Beep(int frequency, int duration) => System.Console.WriteLine("ERROR: Beep is not supported in WebConsole"); 

    public static void Clear()
    {
        AbstractWebConsole.Instance.Clear();
    }

    public static (int Left, int Top) GetCursorPosition()
    {
        System.Console.WriteLine("ERROR: GetCursorPosition is not supported in WebConsole"); 
        return default;
    }

    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
    {
        System.Console.WriteLine("ERROR: MoveBufferArea is not supported in WebConsole"); 
    }

    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
    {
        System.Console.WriteLine("ERROR: MoveBufferArea is not supported in WebConsole"); 
    }

    public static Stream OpenStandardError(int bufferSize) => System.Console.OpenStandardError(bufferSize);

    public static Stream OpenStandardError() => System.Console.OpenStandardError();

    public static Stream OpenStandardInput(int bufferSize) => System.Console.OpenStandardInput(bufferSize);

    public static Stream OpenStandardInput() => System.Console.OpenStandardInput();

    public static Stream OpenStandardOutput(int bufferSize) => System.Console.OpenStandardOutput(bufferSize);

    public static Stream OpenStandardOutput() => System.Console.OpenStandardOutput();

    public static int Read()
    { 
        System.Console.WriteLine("ERROR: Read is not supported in WebConsole"); 
        return default; 
    }

    public static ConsoleKeyInfo ReadKey(bool intercept)
    { 
        System.Console.WriteLine("ERROR: ReadKey is not supported in WebConsole"); 
        return default; 
    }

    public static ConsoleKeyInfo ReadKey() { 
        System.Console.WriteLine("ERROR: ReadKey is not supported in WebConsole"); 
        return default; 
    }

    public static async Task<string?> ReadLine() {
        return await AbstractWebConsole.Instance.ReadLine();
    }


    public static void ResetColor() => System.Console.WriteLine("ERROR: ResetColor is not supported in WebConsole");


    public static void SetBufferSize(int width, int height) => System.Console.WriteLine("ERROR: SetBufferSize is not supported in WebConsole");


    public static void SetCursorPosition(int left, int top) => System.Console.WriteLine("ERROR: SetCursorPosition is not supported in WebConsole");

    public static void SetError(TextWriter newError) => System.Console.SetError(newError);
    public static void SetIn(TextReader newIn) => System.Console.WriteLine("ERROR: SetIn is not supported in WebConsole");

    public static void SetOut(TextWriter newOut) => System.Console.SetOut(newOut);

    public static void SetWindowPosition(int left, int top) => System.Console.WriteLine("ERROR: SetWindowPosition is not supported in WebConsole");

    public static void SetWindowSize(int width, int height) => System.Console.WriteLine("ERROR: SetWindowSize is not supported in WebConsole");

    public static void Write(ulong value) => System.Console.Write(value);

    public static void Write(bool value) => System.Console.Write(value);

    public static void Write(char value) => System.Console.Write(value);

    public static void Write(char[]? buffer) => System.Console.Write(buffer);

    public static void Write(int value) => System.Console.Write(value);

    public static void Write(decimal value) => System.Console.Write(value);

    public static void Write(long value) => System.Console.Write(value);

    public static void Write(object? value) => System.Console.Write(value);

    public static void Write(float value) => System.Console.Write(value);

    public static void Write(string? value) => System.Console.Write(value);

    public static void Write(string format, object? arg0) => System.Console.Write(format, arg0);

    public static void Write(string format, object? arg0, object? arg1) => System.Console.Write(format, arg0, arg1);

    public static void Write(string format, object? arg0, object? arg1, object? arg2) => System.Console.Write(format, arg0, arg1, arg2);

    public static void Write(string format, params object?[]? arg) => System.Console.Write(format, arg);

    public static void Write(uint value) => System.Console.Write(value);

    public static void Write(char[] buffer, int index, int count) => System.Console.Write(buffer, index, count);

    public static void Write(double value) => System.Console.Write(value);

    public static void WriteLine(uint value) => System.Console.WriteLine(value);

    public static void WriteLine(string format, params object?[]? arg) => System.Console.WriteLine(format, arg);
    public static void WriteLine() => System.Console.WriteLine();

    public static void WriteLine(bool value) => System.Console.WriteLine(value);

    public static void WriteLine(char[]? buffer) => System.Console.WriteLine(buffer);
    public static void WriteLine(char[] buffer, int index, int count) => System.Console.WriteLine(buffer, index, count);

    public static void WriteLine(decimal value) => System.Console.WriteLine(value);

    public static void WriteLine(double value) => System.Console.WriteLine(value);

    public static void WriteLine(ulong value) => System.Console.WriteLine(value);

    public static void WriteLine(int value) => System.Console.WriteLine(value);

    public static void WriteLine(object? value) => System.Console.WriteLine(value);

    public static void WriteLine(float value) => System.Console.WriteLine(value);

    public static void WriteLine(string? value) => System.Console.WriteLine(value);

    public static void WriteLine(string format, object? arg0) => System.Console.WriteLine(format, arg0);

    public static void WriteLine(string format, object? arg0, object? arg1) => System.Console.WriteLine(format, arg0, arg1);

    public static void WriteLine(string format, object? arg0, object? arg1, object? arg2) => System.Console.WriteLine(format, arg0, arg1, arg2);
    public static void WriteLine(long value) => System.Console.WriteLine(value);

    public static void WriteLine(char value) => System.Console.WriteLine(value);
}

public class NotAvailableInWebException : Exception
{
    public NotAvailableInWebException(string? message) : base(message)
    {
    }
}