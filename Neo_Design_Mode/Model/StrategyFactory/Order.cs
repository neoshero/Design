using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.StrategyFactory
{
    /// <summary>
    /// 订单基类
    /// </summary>
    public class Order
    {
        public Order()
        {
            this.Table = new List<Detail>();
        }

        /// <summary>
        /// 订单号
        /// </summary>
        public string No { get; set; }

        public List<Detail> Table { get; set; }
    }
}
