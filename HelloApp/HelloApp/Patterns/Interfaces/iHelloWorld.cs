using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.Patterns.Interfaces
{
    // for implementing a simple Factory pattern
    // defining an interface
    public interface IHelloWorld
    {
        string TxtData { get; set; }
        string GetText();
    }
}
