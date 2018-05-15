using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMVP2
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.ViewCalculate += PresenterCalculate;
        }

        private string PresenterCalculate(int first, string op, int second)
        {
            if (op == "/" && second == 0)
                return "You can't devide by zero!";
            else
                return model.ModelCalculate(first, op, second);
        }
    }
}
