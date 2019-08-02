using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCBasic.Model;

namespace MVCBasic.BusinessLayer
{
    public class CalculationService
    {
        public int calculate(Calculator calculator)
        {
            int result = 0;
            switch (calculator.Operator) {
                case "＋":
                    result = calculator.LeftNum + calculator.RightNum;
                    break;
                case "－":
                    result = calculator.LeftNum - calculator.RightNum;
                    break;
                case "×":
                    result = calculator.LeftNum * calculator.RightNum;
                    break;
                case "÷":
                    result = calculator.LeftNum / calculator.RightNum;
                    break;
            }

            return result;
        }
    }
}
