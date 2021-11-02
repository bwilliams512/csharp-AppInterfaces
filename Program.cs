/*
In this project, a fictional team at a fictional company has asked me 
to join their product team to develop the hottest new computer. 
Here I am responsible for building some of the standard apps on this new machine, 
specifically the to-do list and the password manager.

At this point in development I have two classes started: 
TodoList representing the to-do list application and 
PasswordManager representing the password manager. 

In order to work within the company system, every app must have a display and reset feature. 
Each class will need to implement the IDisplayable and IResetable interfaces.
*/

using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Attend 8:30 am meeting");
      tdl.Add("Contact delivery managers");
      tdl.Add("Provide status updates");

      PasswordManager pm = new PasswordManager("voyage", true);
      
      // Call Display() and Reset() with tdl and pm
      tdl.Display();
      tdl.Reset();
      tdl.Display();

      pm.Display();
      pm.Reset();
      pm.Display();

    }
  }
}
