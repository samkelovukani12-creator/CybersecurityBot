// See https://aka.ms/new-console-template for more information
using System;
using System.Media;


// =====================================================
// MAIN PROGRAM
// =====================================================

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(@"_________        ___.                                                  .__  __           __________        __   
\_   ___ \___.__.\_ |__   ___________  ______ ____   ____  __ _________|__|/  |_ ___.__. \______   \ _____/  |_ 
/    \  \<   |  | | __ \_/ __ \_  __ \/  ___// __ \_/ ___\|  |  \_  __ \  \   __<   |  |  |    |  _//  _ \   __\
\     \___\___  | | \_\ \  ___/|  |  /\___ \\  ___/\  \___|  |  /|  | \/  ||  |  \___  |  |    |   (  <_> )  |  
 \______  / ____| |___  /\___  >__|  /____  >\___  >\___  >____/ |__|  |__||__|  / ____|  |______  /\____/|__|  
        \/\/          \/     \/           \/     \/     \/                       \/              \/             
");

        Console.ResetColor();

        // =====================================================
        // STARTUP SOUND
        // =====================================================

        try
        {
            SoundPlayer player = new SoundPlayer("Startup.wav");
            player.Play();
        }
        catch
        {
            Console.WriteLine("Chatbot: Startup sound could not be played.");
        }

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("       WELCOME TO THE CHATBOT");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        // =====================================================
        // USER NAME INPUT
        // =====================================================

        string name;

        while (true)
        {
            Console.Write("User: What is your name? ");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) && name.Trim().Length >= 2)
            {
                name = name.Trim();
                break;
            }

            Console.WriteLine("Chatbot: Please enter a valid name.");
            Console.WriteLine("Chatbot: Your name must contain at least 2 characters.");
            Console.WriteLine();
        }

        Console.WriteLine();

        // Create chatbot object
        CybersecurityChatbot chatbot = new CybersecurityChatbot(name);

        // Start chatbot
        chatbot.StartChat();
    }
}
