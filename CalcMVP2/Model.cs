using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVP2
{
    public class Model
    {
        internal string ModelCalculate(double first, string op, double second)
        {
            switch (op)
            {
                case "+":
                    return (first + second).ToString();
                case "-":
                    return (first - second).ToString();
                case "*":
                    return (first * second).ToString();
                case "/":
                    return (first / second).ToString();
                default:
                    return "";
            }
        }
    }
}
