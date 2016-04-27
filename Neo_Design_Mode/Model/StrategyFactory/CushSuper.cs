using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.StrategyFactory
{

    public class CushSuper : ICushSuper
    {
        public virtual decimal GetMoney(decimal money)
        {
            return money;
        }
    }

    /// <summary>
    /// 折扣算法
    /// </summary>
    public class CushForDiscount : CushSuper
    {
        private readonly decimal _discount = 0;

        public CushForDiscount(decimal discount)
        {
            this._discount = discount;
        }

        public override decimal GetMoney(decimal money)
        {
            return money * _discount;
        }
    }

    /// <summary>
    /// 满减策略
    /// </summary>
    public class CushForReduction : CushSuper
    {
        private readonly decimal _target;
        private readonly decimal _favorable;

        public CushForReduction(decimal target, decimal favorable)
        {
            this._target = target;
            this._favorable = favorable;
        }

        public decimal GetMoney(decimal money)
        {
            return money >= _target ? money - _favorable : money;
        }
    }

    /// <summary>
    /// 满送策略
    /// </summary>
    public class CushForPersent : CushSuper
    {
        private readonly decimal _target;

        public CushForPersent(decimal target)
        {
            this._target = target;
        }

        public decimal GetMoney(decimal money)
        {
            return money;
        }
    }
}
