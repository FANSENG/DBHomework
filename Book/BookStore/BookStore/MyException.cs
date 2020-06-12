using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LibraryManager
{
    [Serializable]
    public class MyException : Exception
    {
        public string MyInfo;
        public MyException() : base() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        //当异常从远程处理服务器传播到客户端时，需要该构造函数进行序列化
        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
