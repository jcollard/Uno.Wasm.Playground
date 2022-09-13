using System.Text;

namespace CaptainCoder.WebConsole;
public abstract class AbstractWebConsole : IConsole
{
    private static AbstractWebConsole? _instance;

    public abstract event ConsoleCancelEventHandler? CancelKeyPress;

    public static AbstractWebConsole Instance {
        get {
            if (_instance == null) throw new InvalidOperationException("The WebConsole Instance was null.");
            return _instance;
        }
        private set => _instance = value;
    }

    public abstract bool IsInputRedirected { get; }
    public abstract int BufferHeight { get; set; }
    public abstract int BufferWidth { get; set; }
    public abstract bool CapsLock { get; }
    public abstract int CursorLeft { get; set; }
    public abstract int CursorSize { get; set; }
    public abstract int CursorTop { get; set; }
    public abstract bool CursorVisible { get; set; }
    public abstract TextWriter Error { get; }
    public abstract ConsoleColor ForegroundColor { get; set; }
    public abstract TextReader In { get; }
    public abstract Encoding InputEncoding { get; set; }
    public abstract bool IsErrorRedirected { get; }
    public abstract int WindowWidth { get; set; }
    public abstract bool IsOutputRedirected { get; }
    public abstract bool KeyAvailable { get; }
    public abstract int LargestWindowHeight { get; }
    public abstract int LargestWindowWidth { get; }
    public abstract bool NumberLock { get; }
    public abstract TextWriter Out { get; }
    public abstract Encoding OutputEncoding { get; set; }
    public abstract string Title { get; set; }
    public abstract bool TreatControlCAsInput { get; set; }
    public abstract int WindowHeight { get; set; }
    public abstract int WindowLeft { get; set; }
    public abstract int WindowTop { get; set; }
    public abstract ConsoleColor BackgroundColor { get; set; }

    protected AbstractWebConsole() {
        if (AbstractWebConsole._instance != null) throw new InvalidOperationException("The WebConsole is a Singleton.");
        AbstractWebConsole.Instance = this;
    }

    public abstract Task<string?> ReadLine();
    public abstract void Clear();
    public abstract void Beep();
    public abstract void Beep(int frequency, int duration);
    public abstract (int Left, int Top) GetCursorPosition();
    public abstract void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor);
    public abstract void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);
    public abstract Stream OpenStandardError(int bufferSize);
    public abstract Stream OpenStandardError();
    public abstract Stream OpenStandardInput(int bufferSize);
    public abstract Stream OpenStandardInput();
    public abstract Stream OpenStandardOutput(int bufferSize);
    public abstract Stream OpenStandardOutput();
    public abstract Task<int> Read();
    public abstract Task<ConsoleKeyInfo> ReadKey(bool intercept);
    public abstract Task<ConsoleKeyInfo> ReadKey();
    public abstract void ResetColor();
    public abstract void SetBufferSize(int width, int height);
    public abstract void SetCursorPosition(int left, int top);
    public abstract void SetError(TextWriter newError);
    public abstract void SetIn(TextReader newIn);
    public abstract void SetOut(TextWriter newOut);
    public abstract void SetWindowPosition(int left, int top);
    public abstract void SetWindowSize(int width, int height);
    public abstract void Write(ulong value);
    public abstract void Write(bool value);
    public abstract void Write(char value);
    public abstract void Write(char[]? buffer);
    public abstract void Write(int value);
    public abstract void Write(decimal value);
    public abstract void Write(long value);
    public abstract void Write(object? value);
    public abstract void Write(float value);
    public abstract void Write(string? value);
    public abstract void Write(string format, object? arg0);
    public abstract void Write(string format, object? arg0, object? arg1);
    public abstract void Write(string format, object? arg0, object? arg1, object? arg2);
    public abstract void Write(string format, params object?[]? arg);
    public abstract void Write(uint value);
    public abstract void Write(char[] buffer, int index, int count);
    public abstract void Write(double value);
    public abstract void WriteLine(uint value);
    public abstract void WriteLine(string format, params object?[]? arg);
    public abstract void WriteLine();
    public abstract void WriteLine(bool value);
    public abstract void WriteLine(char[]? buffer);
    public abstract void WriteLine(char[] buffer, int index, int count);
    public abstract void WriteLine(decimal value);
    public abstract void WriteLine(double value);
    public abstract void WriteLine(ulong value);
    public abstract void WriteLine(int value);
    public abstract void WriteLine(object? value);
    public abstract void WriteLine(float value);
    public abstract void WriteLine(string? value);
    public abstract void WriteLine(string format, object? arg0);
    public abstract void WriteLine(string format, object? arg0, object? arg1);
    public abstract void WriteLine(string format, object? arg0, object? arg1, object? arg2);
    public abstract void WriteLine(long value);
    public abstract void WriteLine(char value);
}