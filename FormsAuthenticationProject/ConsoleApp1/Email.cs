using System;
using System.Collections.Generic;
using System.Text;



namespace DependencyInjectionImplementation
{
    public class Email : IMessage
    {
        public string Contact { get; set; }
        
    }
}
