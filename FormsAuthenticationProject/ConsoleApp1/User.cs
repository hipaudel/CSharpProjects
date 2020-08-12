using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionImplementation
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IMessage Message { get; set; }



    }

}
