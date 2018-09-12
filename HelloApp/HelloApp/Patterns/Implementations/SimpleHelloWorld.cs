using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloApp.Patterns.Interfaces;

namespace HelloApp.Patterns.Implementations
{
    //defining a concerete class for returning a simple hardcoded hello world
    public class SimpleHelloWorld : IHelloWorld
    {
        string _TxtData = string.Empty;
        public string TxtData
        {
            get { return _TxtData; }
            set { _TxtData = value; }
        }

        public string GetText()
        {
            return TxtData;
        }

    }
}