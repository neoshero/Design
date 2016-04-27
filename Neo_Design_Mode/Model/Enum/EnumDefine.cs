using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Enum
{
    /// <summary>
    /// 运算符
    /// </summary>
    public enum OperatorEnum
    {
        /// <summary>
        /// 加法
        /// </summary>
        [Description("加法")]
        Addition = 1,

        /// <summary>
        /// 减法
        /// </summary>
        [Description("减法")]
        Substract = 2,

        /// <summary>
        /// 乘法
        /// </summary>
        [Description("乘法")]
        Multiply = 3,

        /// <summary>
        /// 除法
        /// </summary>
        [Description("除法")]
        Division = 4
    }

    /// <summary>
    /// 销售策略
    /// </summary>
    public enum StrategyEnum
    {
        /// <summary>
        /// 折扣8
        /// </summary>
        [Description("折扣8")]
        Discount = 1,

        /// <summary>
        /// 满100减20
        /// </summary>
        [Description("满100减20")]
        Reduction = 2,

        /// <summary>
        /// 满300送礼物
        /// </summary>
        [Description("满300送礼物")]
        Present = 3,
    }
}
