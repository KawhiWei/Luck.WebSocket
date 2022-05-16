using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck.WebSocket.Server
{
    public static class TypeExtension
    {
        /// <summary>
        /// 基础类型
        /// </summary>
        private static readonly Type[] BasicTypes =
        {
            typeof(bool),

            typeof(sbyte),
            typeof(byte),
            typeof(int),
            typeof(uint),
            typeof(short),
            typeof(ushort),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),

            typeof(Guid),

            typeof(DateTime),// IsPrimitive:False
            typeof(TimeSpan),// IsPrimitive:False
            typeof(DateTimeOffset),

            typeof(char),
            typeof(string),// IsPrimitive:False

            //typeof(object),// IsPrimitive:False
        };

        public static bool IsBasicType([NotNull] this Type type) => BasicTypes.Contains(type) || type.IsEnum;
    }
}
