// See https://aka.ms/new-console-template for more information
using System.Media;

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
Console.ReadLine();
