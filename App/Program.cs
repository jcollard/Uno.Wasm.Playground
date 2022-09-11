
// See https://aka.ms/new-console-template for more information
Console.SetOut(CaptainCoder.WebConsole.WebConsole.Instance.TextWriter);
Execute();


async void Execute() {
    // See https://aka.ms/new-console-template for more information
    // run command: dotnet run --project bio
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("This is a bio folder writer. ");
    //get input
    string name;
    Console.Write("Please enter your name: ");
    name = (await CaptainCoder.WebConsole.Console.ReadLine());

    CaptainCoder.WebConsole.Console.Clear();

    Console.WriteLine("Creating file");
    Console.WriteLine("////////////");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("||//////////");
    await CaptainCoder.WebConsole.Thread.Sleep(800);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("|||||///////");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("||||||//////");
    await CaptainCoder.WebConsole.Thread.Sleep(80);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("|||||||/////");
    await CaptainCoder.WebConsole.Thread.Sleep(20);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("||||||||////");
    await CaptainCoder.WebConsole.Thread.Sleep(30);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("|||||||||///");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating file");
    Console.WriteLine("||||||||||||");
    await CaptainCoder.WebConsole.Thread.Sleep(600);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Successfully Created File!");
    await CaptainCoder.WebConsole.Thread.Sleep(700);
    CaptainCoder.WebConsole.Console.Clear();

    //-----------------------------------------------
    string age;
    Console.WriteLine(name + "'s Bio Folder: ");
    Console.Write("Age: ");
    age = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    string bornage;
    Console.WriteLine(name + "'s Bio Folder: ");
    Console.WriteLine("Birthdate(Enter in this format: month/day/year): ");
    bornage = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    string height;
    Console.WriteLine(name + "'s Bio Folder: ");
    Console.WriteLine("Height: ");
    height = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    string gender;
    Console.WriteLine(name + "'s Bio Folder: ");
    Console.WriteLine("Gender(If you feel uncomfortable just leave this blank): ");
    gender = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    string shortbio;
    Console.WriteLine(name + "'s Bio Folder: ");
    Console.WriteLine("Write a small description about yourself: ");
    shortbio = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    string input;
    Console.WriteLine("Press enter to display Bio Card");
    input = (await CaptainCoder.WebConsole.Console.ReadLine());
    CaptainCoder.WebConsole.Console.Clear();

    //-----------------------------------------------

    Console.WriteLine("Getting Inputs");
    Console.WriteLine("////////////");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Compressing Inputs");
    Console.WriteLine("|///////////");
    await CaptainCoder.WebConsole.Thread.Sleep(800);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Starting secret Hyperdrive");
    Console.WriteLine("||||||//////");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Starting secret Hyperdrive");
    Console.WriteLine("|||||||/////");
    await CaptainCoder.WebConsole.Thread.Sleep(80);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Running secret Hyperdrive");
    Console.WriteLine("|||||||||///");
    await CaptainCoder.WebConsole.Thread.Sleep(20);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Running secret Hyperdrive");
    Console.WriteLine("||||||||||//");
    await CaptainCoder.WebConsole.Thread.Sleep(30);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Exporting modules");
    Console.WriteLine("||||||||||//");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating Bio");
    Console.WriteLine("||||||||||||");
    await CaptainCoder.WebConsole.Thread.Sleep(600);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Creating Bio");
    Console.WriteLine("||||||||||||");
    await CaptainCoder.WebConsole.Thread.Sleep(200);
    CaptainCoder.WebConsole.Console.Clear();
    Console.WriteLine("Successfully created Card!");
    await CaptainCoder.WebConsole.Thread.Sleep(700);
    CaptainCoder.WebConsole.Console.Clear();

    Console.WriteLine("Name: [" + name + "]");
    Console.WriteLine("Age: [" + age + "]");
    Console.WriteLine("Date of Birth: [" + bornage + "]");
    Console.WriteLine("Height: [" + height + "]");
    Console.WriteLine("Gender: [" + gender + "]");
    Console.WriteLine("Short Biography:");
    Console.WriteLine(shortbio);

}