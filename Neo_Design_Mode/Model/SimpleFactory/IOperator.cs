using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SimpleFactory
{
    /// <summary>
    /// 基础类接口
    /// </summary>
    public interface IOperator
    {
        double NumberA { get; set; }

        double NumberB { get; set; }

        /// <summary>
        /// 核心功能
        /// </summary>
        /// <returns></returns>
        double GetResult();
    }
}
