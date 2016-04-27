using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enum;

namespace Model.StrategyFactory
{
    public class CushContext
    {
        private readonly CushSuper cush = null;

        public CushContext(StrategyEnum mode)
        {
            switch (mode)
            {
                case StrategyEnum.Discount: cush = new CushForDiscount(0.8m);
                    break;
                case StrategyEnum.Reduction: cush = new CushForReduction(100,20);
                    break;
                case StrategyEnum.Present: cush = new CushForPersent(300);
                    break;
                default:cush = new CushSuper();
                    break;
            }
        }

        /// <summary>
        /// 获取需要支付的金额
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public decimal GetResult(decimal money)
        {
            return cush.GetMoney(money);
        }
    }
}
