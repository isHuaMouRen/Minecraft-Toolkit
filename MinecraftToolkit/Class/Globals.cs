using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftToolkit.Class
{
    public static class Globals
    {
        public static class Var
        {
            public static readonly string ExecutePath = $"{Assembly.GetExecutingAssembly().Location}";//执行位置
            public static readonly string Version = $"1.0.0-alpha.1";//版本号
        }
    }
}
