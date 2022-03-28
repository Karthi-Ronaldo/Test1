using System;

namespace Calculation
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a > b ? a - b : b - a;
        }

        public int Mul(int a,int b)
        {
            return a * b;
        }

        public float Div(int a, int b)
        {
            return a / b;
        }
    }
}
