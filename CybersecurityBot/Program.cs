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


class CybersecurityChatbot : User
{
    private Random random = new Random();

    // 2D array that will store cybersecurity tips
    private string[,] TipsDatabase =
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


    // Constructor
    public CybersecurityChatbot(string name) : base(name)
    {
    }


    // =================================================
    // START CHATBOT
    // =================================================

    public void StartChat()
    {
        Console.WriteLine("==============================================");
        Console.Writeline("WELCOME TO THE CYBERSECURITY CHATBOT");
        Console.WriteLine();

        Console.WriteLine("Chatbot: Application running.....");
        Console.WriteLine();

        Console.WriteLine($"Chatbot: Hello {name}!");
        Console.WriteLine("Chatbot: Welcome to the Cybersecurity Chatbot.");
        Console.WriteLine("Chatbot: I am here to help you stay safe online.");
        Console.WriteLine();

        Console.WriteLine("Chatbot: You can ask me questions about:");
        Console.WriteLine("- Passwords");
        Console.WriteLine("- Phishing");
        Console.WriteLine("- Malware");
        Console.WriteLine("- Hacking");
        Console.WriteLine("- Two-factor authentication");
        Console.WriteLine("- Social media");
        Console.WriteLine("- Public Wi-Fi");
        Console.WriteLine("- Antivirus");
        Console.WriteLine("- Online privacy");
        Console.WriteLine();

        Console.WriteLine("Chatbot: Type 'exit' when you want to end our conversation.");
        Console.WriteLine();

        Conversation();
    }


    // =================================================
    // CONVERSATION METHOD
    // =================================================

    private void Conversation()
    {
        while (true)
        {
            Console.Write($"{name}: ");

            string input = Console.ReadLine();

            // Input validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Chatbot: Please enter a question or message.");
                Console.WriteLine();
                continue;
            }

            string message = input.ToLower().Trim();

            // Exit
            if (message == "exit" ||
                message == "quit" ||
                message == "bye")
            {
                Console.WriteLine();
                Console.WriteLine($"Chatbot: Goodbye {name}!");
                Console.WriteLine("Chatbot: Remember to stay safe online.");
                break;
            }

            // Process user's message
            RespondToUser(message);

            Console.WriteLine();
        }
    }


    // =================================================
    // RESPOND TO USER
    // =================================================

    private void RespondToUser(string message)
    {

        // ---------------------------------------------
        // GREETING
        // ---------------------------------------------

        if (message.Contains("hello") ||
            message.Contains("hi") ||
            message.Contains("hey"))
        {
            Console.WriteLine($"Chatbot: Hello {name}! How can I help you today?");
        }


        // ---------------------------------------------
        // HOW ARE YOU
        // ---------------------------------------------

        else if (message.Contains("how are you"))
        {
            Console.WriteLine("Chatbot: I'm doing great!");
            Console.WriteLine("Chatbot: I'm ready to help you with cybersecurity.");
        }


        // ---------------------------------------------
        // USER'S NAME
        // ---------------------------------------------

        else if (message.Contains("my name"))
        {
            Console.WriteLine($"Chatbot: Your name is {name}.");
        }


        // ---------------------------------------------
        // PASSWORD
        // ---------------------------------------------

        else if (message.Contains("password"))
        {
            Console.WriteLine("Chatbot: Password security is very important.");

            int randomIndex = random.Next(0, 3);

            Console.WriteLine("Chatbot: Here is a password security tip:");
            Console.WriteLine(TipsDatabase[0, randomIndex]);

            Console.WriteLine();
            Console.WriteLine("Chatbot: Would you like to know how to create a strong password?");
        }


        // ---------------------------------------------
        // STRONG PASSWORD
        // ---------------------------------------------

        else if (message.Contains("strong password") ||
                 message.Contains("create a password"))
        {
            Console.WriteLine("Chatbot: A strong password should:");

            Console.WriteLine("1. Be at least 12–16 characters long.");
            Console.WriteLine("2. Use uppercase and lowercase letters.");
            Console.WriteLine("3. Include numbers and symbols.");
            Console.WriteLine("4. Be unique for every account.");
            Console.WriteLine("5. Avoid personal information.");
        }


        // ---------------------------------------------
        // PHISHING
        // ---------------------------------------------

        else if (message.Contains("phishing") ||
                 message.Contains("phish"))
        {
            Console.WriteLine("Chatbot: Phishing is a cyberattack where");
            Console.WriteLine("criminals pretend to be a trusted person");
            Console.WriteLine("or organisation to steal sensitive information.");

            int randomIndex = random.Next(0, 3);

            Console.WriteLine();
            Console.WriteLine("Chatbot: Here is a phishing safety tip:");
            Console.WriteLine(TipsDatabase[1, randomIndex]);

            Console.WriteLine();
            Console.WriteLine("Chatbot: Would you like to know how to identify phishing?");
        }


        // ---------------------------------------------
        // PHISHING SIGNS
        // ---------------------------------------------

        else if (message.Contains("identify phishing") ||
                 message.Contains("signs of phishing"))
        {
            Console.WriteLine("Chatbot: Some common signs of phishing include:");

            Console.WriteLine("- Suspicious links.");
            Console.WriteLine("- Urgent or threatening messages.");
            Console.WriteLine("- Requests for passwords.");
            Console.WriteLine("- Unexpected attachments.");
            Console.WriteLine("- Spelling and grammar mistakes.");
            Console.WriteLine("- Messages pretending to be from trusted companies.");
        }


        // ---------------------------------------------
        // MALWARE
        // ---------------------------------------------

        else if (message.Contains("malware") ||
                 message.Contains("virus"))
        {
            Console.WriteLine("Chatbot: Malware is malicious software");
            Console.WriteLine("designed to damage systems, steal information");
            Console.WriteLine("or gain unauthorised access.");

            int randomIndex = random.Next(0, 3);

            Console.WriteLine();
            Console.WriteLine("Chatbot: Here is a malware safety tip:");
            Console.WriteLine(TipsDatabase[2, randomIndex]);
        }


        // ---------------------------------------------
        // HACKING
        // ---------------------------------------------

        else if (message.Contains("hacking") ||
                 message.Contains("hacker"))
        {
            Console.WriteLine("Chatbot: Hacking involves gaining access");
            Console.WriteLine("to a computer system, network or account.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: You can protect yourself by:");
            Console.WriteLine("- Using strong passwords.");
            Console.WriteLine("- Enabling two-factor authentication.");
            Console.WriteLine("- Keeping your software updated.");
            Console.WriteLine("- Avoiding suspicious links.");
        }


        // ---------------------------------------------
        // TWO-FACTOR AUTHENTICATION
        // ---------------------------------------------

        else if (message.Contains("two factor") ||
                 message.Contains("2fa"))
        {
            Console.WriteLine("Chatbot: Two-factor authentication, or 2FA,");
            Console.WriteLine("adds an additional layer of security.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: It requires something more than");
            Console.WriteLine("just your password to access your account.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: I recommend enabling 2FA on important accounts.");
        }


        // ---------------------------------------------
        // SOCIAL MEDIA
        // ---------------------------------------------

        else if (message.Contains("social media") ||
                 message.Contains("instagram") ||
                 message.Contains("facebook") ||
                 message.Contains("tiktok"))
        {
            Console.WriteLine("Chatbot: To stay safe on social media:");

            Console.WriteLine("- Keep your account private where appropriate.");
            Console.WriteLine("- Avoid sharing sensitive information.");
            Console.WriteLine("- Use strong passwords.");
            Console.WriteLine("- Enable two-factor authentication.");
            Console.WriteLine("- Be careful when accepting friend requests.");
            Console.WriteLine("- Avoid suspicious links.");
        }


        // ---------------------------------------------
        // PUBLIC WI-FI
        // ---------------------------------------------

        else if (message.Contains("wifi") ||
                 message.Contains("wi-fi") ||
                 message.Contains("public wi-fi"))
        {
            Console.WriteLine("Chatbot: Public Wi-Fi can be risky.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: When using public Wi-Fi:");
            Console.WriteLine("- Avoid accessing sensitive accounts.");
            Console.WriteLine("- Make sure websites use HTTPS.");
            Console.WriteLine("- Keep your firewall enabled.");
            Console.WriteLine("- Avoid suspicious Wi-Fi networks.");
        }


        // ---------------------------------------------
        // ANTIVIRUS
        // ---------------------------------------------

        else if (message.Contains("antivirus") ||
                 message.Contains("anti-virus"))
        {
            Console.WriteLine("Chatbot: Antivirus software helps detect,");
            Console.WriteLine("block and remove certain types of malware.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: Make sure your antivirus software");
            Console.WriteLine("is updated regularly.");
        }


        // ---------------------------------------------
        // PRIVACY
        // ---------------------------------------------

        else if (message.Contains("privacy") ||
                 message.Contains("personal information"))
        {
            Console.WriteLine("Chatbot: Protecting your personal information");
            Console.WriteLine("is very important.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: Never share sensitive information such as:");
            Console.WriteLine("- Passwords");
            Console.WriteLine("- PINs");
            Console.WriteLine("- Banking details");
            Console.WriteLine("- Identity information");
            Console.WriteLine("- Security codes");
        }


        // ---------------------------------------------
        // SOFTWARE UPDATES
        // ---------------------------------------------

        else if (message.Contains("update") ||
                 message.Contains("software update"))
        {
            Console.WriteLine("Chatbot: Software updates are important");
            Console.WriteLine("because they often contain security fixes.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: Keep your operating system,");
            Console.WriteLine("browser and applications updated.");
        }


        // ---------------------------------------------
        // RANDOM TIP
        // ---------------------------------------------

        else if (message.Contains("tip") ||
                 message.Contains("advice") ||
                 message.Contains("help"))
        {
            GiveRandomTip();
        }


        // ---------------------------------------------
        // THANK YOU
        // ---------------------------------------------

        else if (message.Contains("thank you") ||
                 message.Contains("thanks"))
        {
            Console.WriteLine($"Chatbot: You're welcome, {name}!");
            Console.WriteLine("Chatbot: I'm always happy to help.");
        }


        // ---------------------------------------------
        // UNKNOWN INPUT
        // ---------------------------------------------

        else
        {
            Console.WriteLine("Chatbot: I'm not sure I understand that.");

            Console.WriteLine();
            Console.WriteLine("Chatbot: You can ask me about passwords,");
            Console.WriteLine("phishing, malware, hacking, 2FA, social media,");
            Console.WriteLine("Wi-Fi, antivirus or online privacy.");
        }
    }


    // =================================================
    // RANDOM CYBERSECURITY TIP
    // =================================================

    private void GiveRandomTip()
    {
        int category = random.Next(0, 3);
        int tip = random.Next(0, 3);

        string categoryName;

        if (category == 0)
        {
            categoryName = "Password Security";
        }
        else if (category == 1)
        {
            categoryName = "Phishing";
        }
        else
        {
            categoryName = "Malware";
        }

        Console.WriteLine($"Chatbot: Here is a random {categoryName} tip:");
        Console.WriteLine(TipsDatabase[category, tip]);
    }
}


// =====================================================
// MAIN PROGRAM
// =====================================================

class Program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("       WELCOME TO THE CHATBOT");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        // Input validation for name
        string name;

        while (true)
        {
            Console.Write("User: What is your name? ");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) &&
                name.Length >= 2)
            {
                break;
            }

            Console.WriteLine("Chatbot: Please enter a valid name.");
            Console.WriteLine("Chatbot: Your name must contain at least 2 characters.");
            Console.WriteLine();
        }

        Console.WriteLine();

        // Create an object from the inherited class
        CybersecurityChatbot chatbot =
            new CybersecurityChatbot(name);

        // Start the conversation
        chatbot.StartChat();
    }
}