using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test1
{
    [TestFixture]
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            NUnitColorConsole.Main(
               new[] { Assembly.GetExecutingAssembly().Location }
               );
        }
    }
}
