using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Entity.Common
{
    public enum HttpResponseTypeCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 200,
        /// <summary>
        /// 失败
        /// </summary>
        Failure = 400,
        /// <summary>
        /// 异常
        /// </summary>
        Exception = 500
    }

    public class HttpResponseType<T>
    {
        public HttpResponseTypeCode code;
        public string message;
        public T data;
    }

    public class HttpResponseType
    {
        public static HttpResponseType<T> Success<T>(T data, string msg = "成功")
        {
            return new HttpResponseType<T>()
            {
                code = HttpResponseTypeCode.Success,
                message = msg,
                data = data
            };
        }

        public static HttpResponseType<T> Failure<T>(string msg = "失败",HttpResponseTypeCode code = HttpResponseTypeCode.Failure)
        {
            return new HttpResponseType<T>()
            {
                code = code,
                message = msg
            };
        }
    }
}

