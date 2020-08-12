using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionImplementation
{
    public class Factory
    {
        public static  IUser CreateUser()
        {
            return new User();
        }

        public static IMessage CreateEmail()
        {
            return new Email();
        }
    }
}
