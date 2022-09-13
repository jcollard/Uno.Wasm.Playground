using System.Reflection;
public partial class Program
{ 
    public static bool doRun = true;
    public static void Run() {
        doRun = false;
        var program = typeof(Program);
        // MethodInfo[] methods = program.GetMethods();
        // var info = program.GetRuntimeMethod("Main", new Type[]{});
        var methods = program.GetRuntimeMethods();
        foreach(var method in methods) {
            if (method.Name == "<Main>$")
            {
                doRun = false;
                var ps = method.GetParameters();
                method.Invoke(null, new object[]{new string[]{}});
            }            
        }
    }
}