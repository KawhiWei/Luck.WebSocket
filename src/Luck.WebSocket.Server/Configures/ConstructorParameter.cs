using System.Reflection;

namespace Luck.WebSocket.Server
{
    /// <summary>
    /// 构造函数参数配置
    /// Constructor parameter
    /// </summary>
    public class ConstructorParameter
    {
        /// <summary>
        /// 构造函数信息
        /// </summary>
        public ConstructorInfo ConstructorInfo { get; set; }
        /// <summary>
        /// 构造函数参数
        /// Parameter in constructor
        /// </summary>
        public ParameterInfo[] ParameterInfos { get; set; }
    }
}
