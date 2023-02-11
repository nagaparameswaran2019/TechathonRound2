using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementPortal.UIModel
{
    public class Result<T>
    {
        public Result(string Message, T Data = default(T), bool IsSuccess = true)
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.Data = Data;
        }

        public Result() { }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }

    public class Result : Result<object>
    {
        public Result(string Message, object Data = null, bool IsSuccess = true) : base(Message, Data, IsSuccess)
        {
        }
    }
}
