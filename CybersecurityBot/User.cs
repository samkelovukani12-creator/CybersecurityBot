using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class User
    {
        // Attribute
        protected string name;

        // Constructor
        public User(string name)
        {
            this.name = name;
        }

        // Method to get the user's name
        public string GetName()
        {
            return name;
        }

        // Method to display the user
        public void DisplayUser()
        {
            Console.WriteLine($"User: {name}");
        }
    }

