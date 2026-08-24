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
        "Make passwords at least 12–16 characters long.",
        "Use a mix of uppercase and lowercase letters, numbers, and symbols when creating passwords.",
        "Alternatively, use a \"passphrase\" made of 4 or more random, unrelated words when creating passwords."
    },
    {
        "I'm reading a book on anti-gravity. I just can't put it down.",
        "Hi Hungry, I'm Dad.",
        "What do you call a fake noodle? An impasta."
    },
    {
        "What do you call a bear with no teeth? A gummy bear.",
        "Why don't scientists trust atoms? Because they make up everything!",
        "What do you get from a pampered cow? Spoiled milk."
    }
};

Random random = new Random();
