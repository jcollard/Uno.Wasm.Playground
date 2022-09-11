namespace CaptainCoder.WebConsole;
public abstract class AbstractWebConsole 
{
    private static AbstractWebConsole? _instance;
    public static AbstractWebConsole Instance {
        get {
            if (_instance == null) throw new InvalidOperationException("The WebConsole Instance was null.");
            return _instance;
        }
        private set => _instance = value;
    }

    protected AbstractWebConsole() {
        if (AbstractWebConsole._instance != null) throw new InvalidOperationException("The WebConsole is a Singleton.");
        AbstractWebConsole.Instance = this;
    }

    public abstract Task<string?> ReadLine();
    public abstract void Clear();

}