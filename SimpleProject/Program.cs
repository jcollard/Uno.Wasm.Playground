// See https://aka.ms/new-console-template for more information
// run command: dotnet run --project bio
Console.Clear();
Console.WriteLine("This is a bio folder writer. ");
//get input
string name;
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.Clear();

Console.WriteLine("Creating file");
Console.WriteLine("////////////");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("||//////////");
Thread.Sleep(800);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("|||||///////");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("||||||//////");
Thread.Sleep(80);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("|||||||/////");
Thread.Sleep(20);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("||||||||////");
Thread.Sleep(30);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("|||||||||///");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Creating file");
Console.WriteLine("||||||||||||");
Thread.Sleep(600);
Console.Clear();
Console.WriteLine("Successfully Created File!");
Thread.Sleep(700);
Console.Clear();

//-----------------------------------------------
string age;
Console.WriteLine(name + "'s Bio Folder: ");
Console.WriteLine("Age: ");
age = Console.ReadLine();
Console.Clear();

string bornage;
Console.WriteLine(name + "'s Bio Folder: ");
Console.WriteLine("Birthdate(Enter in this format: month/day/year): ");
bornage = Console.ReadLine();
Console.Clear();

string height;
Console.WriteLine(name + "'s Bio Folder: ");
Console.WriteLine("Height: ");
height = Console.ReadLine();
Console.Clear();

string gender;
Console.WriteLine(name + "'s Bio Folder: ");
Console.WriteLine("Gender(If you feel uncomfortable just leave this blank): ");
gender = Console.ReadLine();
Console.Clear();

string shortbio;
Console.WriteLine(name + "'s Bio Folder: ");
Console.WriteLine("Write a small description about yourself: ");
shortbio = Console.ReadLine();
Console.Clear();

string input;
Console.WriteLine("Press enter to display Bio Card");
input = Console.ReadLine();
Console.Clear();

//-----------------------------------------------

Console.WriteLine("Getting Inputs");
Console.WriteLine("////////////");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Compressing Inputs");
Console.WriteLine("|///////////");
Thread.Sleep(800);
Console.Clear();
Console.WriteLine("Starting secret Hyperdrive");
Console.WriteLine("||||||//////");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Starting secret Hyperdrive");
Console.WriteLine("|||||||/////");
Thread.Sleep(80);
Console.Clear();
Console.WriteLine("Running secret Hyperdrive");
Console.WriteLine("|||||||||///");
Thread.Sleep(20);
Console.Clear();
Console.WriteLine("Running secret Hyperdrive");
Console.WriteLine("||||||||||//");
Thread.Sleep(30);
Console.Clear();
Console.WriteLine("Exporting modules");
Console.WriteLine("||||||||||//");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Creating Bio");
Console.WriteLine("||||||||||||");
Thread.Sleep(600);
Console.Clear();
Console.WriteLine("Creating Bio");
Console.WriteLine("||||||||||||");
Thread.Sleep(200);
Console.Clear();
Console.WriteLine("Successfully created Card!");
Thread.Sleep(700);
Console.Clear();

Console.WriteLine("Name: [" + name + "]");
Console.WriteLine("Age: [" + age + "]");
Console.WriteLine("Date of Birth: [" + bornage + "]");
Console.WriteLine("Height: [" + height + "]");
Console.WriteLine("Gender: [" + gender + "]");
Console.WriteLine("Short Biography:");
Console.WriteLine(shortbio);




// string inputname = " Name: [" + name + "]";
// string inputage = " Age: [" + age + "]";
// string inputbornage = " Date of Birth: [" + bornage + "]";
// string inputheight = " Height: [" + height + "]";
// string inputgender = " Gender: [" + gender + "]";
// string inputbio = " Short Biography:" + shortbio;

// string biocard = inputname + inputage + inputbornage + inputheight + inputgender + inputbio;

// string input2;
// Console.WriteLine("Press enter to copy Bio card to clipboard");
// input2 = Console.ReadLine();
// Console.Clear();

// Clipboard.SetText(biocard.Text);

// Console.WriteLine("Text copied!");
