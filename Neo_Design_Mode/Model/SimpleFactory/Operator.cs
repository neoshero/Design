using System;

namespace Model.SimpleFactory
{
    public class Operator:IOperator
    {
        private double _x = 0;
        private double _y = 0;

        public double NumberA 
        {
            get { return _x; }
            set { _x = value; }
        }

        public double NumberB
        {
            get { return _y; }
            set { _y = value; }
        }

        public virtual double GetResult()
        {
            return 0;
        }
    }




    public class OperatorAddition : Operator
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    public class OperatroSubstract : Operator
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    public class OperatroMultiply : Operator
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    public class OperatroDivision : Operator
    {
        public override double GetResult()
        {
            if (Convert.ToInt32(NumberB) == 0)
            {
                throw new Exception("");
            }
            return NumberA / NumberB;
        }
    }
}
