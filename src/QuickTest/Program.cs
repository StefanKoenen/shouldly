using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest
{
    class Program
    {
        static void Main(string[] args)
        {
            (9).ShouldNotBeAssignableTo<UInt32>(); // Pass
            (9).ShouldNotBeAssignableTo<byte>(); // Pass
            (0xFF).ShouldNotBeAssignableTo<byte>(); // Pass
        }
    }
}
