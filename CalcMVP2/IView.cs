using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVP2
{
    public interface IView
    {
        event Func<int, string, int, string> ViewCalculate;
        string AnswerValue { get; set; }
        int FirstValue { get; set; }
        int SecondValue { get; set; }
    }
}
