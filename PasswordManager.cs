using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    // Define a Display() method:
    public void Display() 
    {
      if (Hidden) 
      {
        Console.WriteLine("********");
      }
      else 
      {
        Console.WriteLine(Password);
      }
    }

    // Define a Reset() method:
    public void Reset() 
    {
      Password = "";
      Hidden = false;
    }
  }
}
