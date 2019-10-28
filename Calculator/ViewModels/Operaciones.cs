using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator.ViewModels
{
    public class Operaciones
    {
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;
        private Button sender;

        void OnSelectNumber(string result)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (result == "0" || currentState < 0)
            {
                result = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            result += pressed;

            double number;
            if (double.TryParse(result, out number))
            {
                result = number.ToString("N0");
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }
    }
}
