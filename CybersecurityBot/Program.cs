// See https://aka.ms/new-console-template for more information
using System;
using System.Media;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@"_________        ___.                                                  .__  __           __________        __   
\_   ___ \___.__.\_ |__   ___________  ______ ____   ____  __ _________|__|/  |_ ___.__. \______   \ _____/  |_ 
/    \  \<   |  | | __ \_/ __ \_  __ \/  ___// __ \_/ ___\|  |  \_  __ \  \   __<   |  |  |    |  _//  _ \   __\
\     \___\___  | | \_\ \  ___/|  | \/\___ \\  ___/\  \___|  |  /|  | \/  ||  |  \___  |  |    |   (  <_> )  |  
 \______  / ____| |___  /\___  >__|  /____  >\___  >\___  >____/ |__|  |__||__|  / ____|  |______  /\____/|__|  
        \/\/          \/     \/           \/     \/     \/                       \/              \/             
");

using SoundPlayer player = new SoundPlayer("Startup.wav");

player.Play();

Console.WriteLine("Application running.....");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! Welcome to the Cybersecurity Chatbot.");
Console.WriteLine();
Console.WriteLine("What is your favorite color?");
string color = Console.ReadLine();
Console.WriteLine($"Great! {color} is a nice color. {color} is actually my favorite color too.");
Console.WriteLine();
Console.WriteLine("How old are you?");
string age = Console.ReadLine();
Console.WriteLine($"Wow, {age} years old! That's a great age to start learning about cybersecurity.");
Console.WriteLine("I can provide you with cybersecurity tips to help you stay safe online.");
Console.WriteLine();

string[,] TipsDatabase = new string[3, 3]
{
    {
        "Use passwords that are at least 12–16 characters long.",
        "Use a unique password for every account and avoid reusing passwords.",
        "Consider using a password manager to securely store your passwords."
    },
    {
        "Be careful of suspicious emails or messages asking for personal information.",
        "Check links carefully before clicking and make sure they come from a trusted source.",
        "Never share your passwords, PINs, or sensitive information through suspicious messages."
    },
    {
        "Keep your operating system and software updated to protect against malware.",
        "Install trusted antivirus or anti-malware software and keep it updated.",
        "Avoid downloading files or programs from unknown or untrusted websites."
    }
};
Random random = new Random();


while (true)
{
   
    Console.WriteLine("What kind of cybersecurity tip do you want?");
    Console.WriteLine("Choose between: Password, Phishing, Malware");

    string input = Console.ReadLine();

    if (input.ToUpper().Contains("PASSWORD"))
    {
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Cybersecurity Tip:");
        Console.WriteLine(TipsDatabase[0, randomIndex]);
    }

    else if (input.ToUpper().Contains("PHISHING"))
    {
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Cybersecurity Tip:");
        Console.WriteLine(TipsDatabase[1, randomIndex]);
    }

    else if (input.ToUpper().Contains("MALWARE"))
    {
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Cybersecurity Tip:");
        Console.WriteLine(TipsDatabase[2, randomIndex]);
    }

    else
    {
        Console.WriteLine( "Invalid input. Please choose between: Password, Phishing, Malware, or Exit.");
    }

    Console.WriteLine();
}
