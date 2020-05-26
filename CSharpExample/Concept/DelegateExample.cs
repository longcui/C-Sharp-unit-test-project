using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMain.Concept
{
    public class DelegateExample
    {
        public delegate int MathDelegate(int a, int b);

        public static int Sum(int a, int b) => a + b;

        public static int Multiplier(int a, int b) => a * b;
    }
}
