using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMathCalculator
{
    class Calculator
    {

        public void DoCalculate(ICalculate calc)
        {
            calc.Calculate();
        }

    }
}
