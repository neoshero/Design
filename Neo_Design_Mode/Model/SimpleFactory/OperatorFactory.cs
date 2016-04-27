using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enum;


namespace Model.SimpleFactory
{
    /// <summary>
    /// 运算工厂类
    /// </summary>
    public class OperatorFactory
    {
        /// <summary>
        /// 创建运算工厂
        /// </summary>
        /// <param name="sign"></param>
        /// <returns></returns>
        public static Operator CreateOperator(OperatorEnum sign)
        {
            Operator facotry = null;
            switch (sign)
            {
                case OperatorEnum.Addition: facotry = new OperatorAddition();
                    break;
                case OperatorEnum.Substract: facotry = new OperatroSubstract();
                    break;
                case OperatorEnum.Multiply: facotry = new OperatroMultiply();
                    break;
                case OperatorEnum.Division: facotry = new OperatroDivision();
                    break;
                default: throw new Exception();
            }

            return facotry;
        }
    }
}
