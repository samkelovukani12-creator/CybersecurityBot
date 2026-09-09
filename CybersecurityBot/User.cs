using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class User
{
    protected string name;

    // Constructor
    public User(string name)
    {
        this.name = name;
    }

    // Method to get user's name
    public string GetName()
    {
        return name;
    }
}