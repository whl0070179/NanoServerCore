using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoServerCore
{
    /// <summary>
    /// RPC 调用类型
    /// </summary>
    public enum RPCType
    {
        Admin,  // 
        Player,
        Server,
    }

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class HttpRPC
    {
    }
}
