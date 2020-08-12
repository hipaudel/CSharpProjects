using DependencyInjectionImplementation;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser user = Factory.CreateUser();
            IMessage email = Factory.CreateEmail();

            email.Contact = "h2paudel@gmail.com";

            user.Id = 1;
            user.Name = "Hari";
            user.Message = email;
                
            

            Console.WriteLine($"{user.Name} is sending message to {user.Message.Contact}");
            Console.ReadLine();

        }
    }
}
