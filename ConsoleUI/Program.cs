using DemoLibrary.Chore;
using DemoLibrary.Person;
using System;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Welcome message
        /// </summary>
        static void WelcomeMessage()
        {
            Console.WriteLine("SOLID Principles");
            Console.WriteLine("The D in SOLID - Dependency Inversion Principle (DIP)");
            Console.WriteLine("Welcome to DIPDemo application!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Display welcome message
            WelcomeMessage();

            #region Owner

            //Create person (owner of the chore)
            IPerson owner = Factory.CreatePerson();

            //Initialize owner
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            #endregion Owner

            #region Chore
            
            //Create chore
            IChore chore = Factory.CreateChore();

            //Initialize chore
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            //Perform work on chore for given hours
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);

            //Complete chore
            chore.CompleteChore();

            #endregion Chore
        }
    }
}
