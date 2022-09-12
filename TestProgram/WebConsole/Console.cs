using System.Text;
using CaptainCoder.WebConsole;

public static class Console
{
    public static AbstractWebConsole Delegate => AbstractWebConsole.Instance;
    public static bool IsInputRedirected =>  Delegate.IsInputRedirected;

    public static int BufferHeight { get => Delegate.BufferHeight; set => Delegate.BufferHeight = value; }
    public static int BufferWidth { get => Delegate.BufferWidth; set => Delegate.BufferWidth = value; }
    public static bool CapsLock  => Delegate.CapsLock;
    public static int CursorLeft { get => Delegate.CursorLeft; set => Delegate.CursorLeft = value; }
    public static int CursorSize { get => Delegate.CursorSize; set => Delegate.CursorSize = value; }
    public static int CursorTop { get => Delegate.CursorTop; set => Delegate.CursorTop = value; }
    public static bool CursorVisible { get => Delegate.CursorVisible; set => Delegate.CursorVisible = value; }
    public static TextWriter Error => Delegate.Error;
    public static ConsoleColor ForegroundColor { get => Delegate.ForegroundColor; set => Delegate.ForegroundColor = value; }
    public static TextReader In => Delegate.In;
    public static Encoding InputEncoding { get => Delegate.InputEncoding; set => Delegate.InputEncoding = value; }
    public static bool IsErrorRedirected => Delegate.IsErrorRedirected;
    public static int WindowWidth { get => Delegate.WindowWidth; set => Delegate.WindowWidth = value; }
    public static bool IsOutputRedirected => Delegate.IsOutputRedirected;
    public static bool KeyAvailable => Delegate.KeyAvailable;
    public static int LargestWindowHeight => Delegate.LargestWindowHeight;
    public static int LargestWindowWidth => Delegate.LargestWindowWidth;
    public static bool NumberLock => Delegate.NumberLock;
    public static TextWriter Out => Delegate.Out;
    public static Encoding OutputEncoding { get => Delegate.OutputEncoding; set => Delegate.OutputEncoding = value; }
    public static string Title { get => Delegate.Title; set => Delegate.Title = value; }
    public static bool TreatControlCAsInput { get => Delegate.TreatControlCAsInput; set => Delegate.TreatControlCAsInput = value; }
    public static int WindowHeight { get => Delegate.WindowHeight; set => Delegate.WindowHeight = value; }
    public static int WindowLeft { get => Delegate.WindowLeft; set => Delegate.WindowLeft = value; }
    public static int WindowTop { get => Delegate.WindowTop; set => Delegate.WindowTop = value; }
    public static ConsoleColor BackgroundColor { get => Delegate.BackgroundColor; set => Delegate.BackgroundColor = value; }
    public static void Beep() => Delegate.Beep();
    public static void Beep(int frequency, int duration) => Delegate.Beep(frequency, duration);
    public static void Clear() => Delegate.Clear();
    public static (int Left, int Top) GetCursorPosition() => Delegate.GetCursorPosition();
    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
    {
        Delegate.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
    }
    public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
    {
        Delegate.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
    }
    public static Stream OpenStandardError(int bufferSize) =>  Delegate.OpenStandardError(bufferSize);
    public static Stream OpenStandardError() =>  Delegate.OpenStandardError();
    public static Stream OpenStandardInput(int bufferSize) =>  Delegate.OpenStandardInput(bufferSize);
    public static Stream OpenStandardInput() =>  Delegate.OpenStandardInput();
    public static Stream OpenStandardOutput(int bufferSize) =>  Delegate.OpenStandardOutput(bufferSize);
    public static Stream OpenStandardOutput() =>  Delegate.OpenStandardOutput();
    public static async Task<int> Read() => await Delegate.Read();
    public static async Task<ConsoleKeyInfo> ReadKey(bool intercept) => await Delegate.ReadKey(intercept);
    public static async Task<ConsoleKeyInfo> ReadKey() => await Delegate.ReadKey();
    public static async Task<string?> ReadLine() => await Delegate.ReadLine();
    public static void ResetColor() =>  Delegate.ResetColor();
    public static void SetBufferSize(int width, int height) =>  Delegate.SetBufferSize(width, height);
    public static void SetCursorPosition(int left, int top) =>  Delegate.SetCursorPosition(left, top);
    public static void SetError(TextWriter newError) =>  Delegate.SetError(newError);
    public static void SetIn(TextReader newIn) =>  Delegate.SetIn(newIn);
    public static void SetOut(TextWriter newOut) =>  Delegate.SetOut(newOut);
    public static void SetWindowPosition(int left, int top) =>  Delegate.SetWindowPosition(left, top);
    public static void SetWindowSize(int width, int height) =>  Delegate.SetWindowSize(width, height);
    public static void Write(ulong value) =>  Delegate.Write(value);
    public static void Write(bool value) =>  Delegate.Write(value);
    public static void Write(char value) =>  Delegate.Write(value);
    public static void Write(char[]? buffer) =>  Delegate.Write(buffer);
    public static void Write(int value) =>  Delegate.Write(value);
    public static void Write(decimal value) =>  Delegate.Write(value);
    public static void Write(long value) =>  Delegate.Write(value);
    public static void Write(object? value) =>  Delegate.Write(value);
    public static void Write(float value) =>  Delegate.Write(value);
    public static void Write(string? value) =>  Delegate.Write(value);
    public static void Write(string format, object? arg0) =>  Delegate.Write(format, arg0);
    public static void Write(string format, object? arg0, object? arg1) =>  Delegate.Write(format, arg0, arg1);
    public static void Write(string format, object? arg0, object? arg1, object? arg2) =>  Delegate.Write(format, arg0, arg1, arg2);
    public static void Write(string format, params object?[]? arg) =>  Delegate.Write(format, arg);
    public static void Write(uint value) =>  Delegate.Write(value);
    public static void Write(char[] buffer, int index, int count) =>  Delegate.Write(buffer, index, count);
    public static void Write(double value) =>  Delegate.Write(value);
    public static void WriteLine(uint value) =>  Delegate.WriteLine(value);
    public static void WriteLine(string format, params object?[]? arg) =>  Delegate.WriteLine(format, arg);
    public static void WriteLine() =>  Delegate.WriteLine();
    public static void WriteLine(bool value) =>  Delegate.WriteLine(value);
    public static void WriteLine(char[]? buffer) =>  Delegate.WriteLine(buffer);
    public static void WriteLine(char[] buffer, int index, int count) =>  Delegate.WriteLine(buffer, index, count);
    public static void WriteLine(decimal value) =>  Delegate.WriteLine(value);
    public static void WriteLine(double value) =>  Delegate.WriteLine(value);
    public static void WriteLine(ulong value) =>  Delegate.WriteLine(value);
    public static void WriteLine(int value) =>  Delegate.WriteLine(value);
    public static void WriteLine(object? value) =>  Delegate.WriteLine(value);
    public static void WriteLine(float value) =>  Delegate.WriteLine(value);
    public static void WriteLine(string? value) =>  Delegate.WriteLine(value);
    public static void WriteLine(string format, object? arg0) =>  Delegate.WriteLine(format, arg0);
    public static void WriteLine(string format, object? arg0, object? arg1) =>  Delegate.WriteLine(format, arg0, arg1);
    public static void WriteLine(string format, object? arg0, object? arg1, object? arg2) =>  Delegate.WriteLine(format, arg0, arg1, arg2);
    public static void WriteLine(long value) =>  Delegate.WriteLine(value);
    public static void WriteLine(char value) =>  Delegate.WriteLine(value);
    public static event ConsoleCancelEventHandler? CancelKeyPress {
        add {
            Delegate.CancelKeyPress += value;
        }
        remove {
            Delegate.CancelKeyPress -= value;
        }
    }
}