using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Enum;

namespace Neo_Design_Mode.Controllers
{
    public class SimpleFactoryController : Controller
    {
        //
        // GET: /SimpleFactory/

        public ActionResult Index()
        {
            return View();
        }

        #region 个人版
        /*
         * DateTime:2016-4-18
         * Author: pengshuxiong
         * 自己写一个计算器的函数 
         * 问题: 只是简单的将功能写出来了,并没有什么可复用性,没有办法移植到其他平台或者重复利用
         * 封装  继承  多态 都没有使用到
         */
        public ActionResult Calculation(double x, double y, OperatorEnum sign)
        {

            double value = 0;
            switch (sign)
            {
                case OperatorEnum.Addition: value = Add(x, y);
                    break;
                case OperatorEnum.Substract: value = Sub(x, y);
                    break;
                case OperatorEnum.Multiply: value = Multiply(x, y);
                    break;
                case OperatorEnum.Division: value = Division(x, y);
                    break;
                default:throw new Exception();
                    
            }

            return Content(value.ToString(CultureInfo.InvariantCulture));
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            if (Convert.ToInt32(y) == 0)
            {
                throw new NullReferenceException();
            }
            return x / y;
        }
        #endregion

        #region 进阶版

       /*
        * 只是使用了封装  继承和多态全部都没有使用到
        * 实际业务比想象中的复杂,这样使用的话,会让开发者崩溃
        * 只使用到了封装和多态  继承这一属性没有很好的使用到 不能灵活的使用
        */
        public ActionResult CalculationForMode(double x, double y, string sign)
        {
            if (string.IsNullOrEmpty(sign))
            {
            }
            double value = 0;
            switch (sign)
            {
                case "+": value = Operator.Addition(x, y);
                    break;
                case "-": value = Operator.Substract(x, y);
                    break;
                case "*": value = Operator.Multiply(x, y);
                    break;
                case "/": value = Operator.Division(x, y);
                    break;
            }

            return Content(value.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

        #region 高阶版
        
        #endregion
    }
}
