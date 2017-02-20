using esports.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esports.Basics.Controller
{
    public class Service : IService
    {
        public string greetings;

        public string GetGreetings()
        {
            return greetings;
        }
    }
}
