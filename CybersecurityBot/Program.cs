// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("Application started!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! Welcome to the Cybersecurity Chatbot.");


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
