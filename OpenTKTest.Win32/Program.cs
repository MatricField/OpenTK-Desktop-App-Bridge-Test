using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace OpenTKTest.Win32
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new GameWindow(500, 500)
            {
                Title = "Test"
            };
            var game = new Game(window);
        }
    }
}
