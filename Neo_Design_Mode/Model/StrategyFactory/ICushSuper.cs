using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.StrategyFactory
{
    public interface ICushSuper
    {
        /// <summary>
        /// 结算方法
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        decimal GetMoney(decimal money);
    }
}
