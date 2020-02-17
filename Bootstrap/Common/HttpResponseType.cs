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

    /// <summary>
    /// 通用HTTP响应体
    /// </summary>
    /// <typeparam name="T">通用HTTP响应体泛型T</typeparam>
    public class HttpResponseType<T>
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public HttpResponseTypeCode code;
        /// <summary>
        /// 消息
        /// </summary>
        public string message;
        /// <summary>
        /// 返回数据
        /// </summary>
        public T data;
    }

    public class HttpResponseType
    {
        /// <summary>
        /// 成功响应快速构造
        /// </summary>
        /// <typeparam name="T">响应数据类型</typeparam>
        /// <param name="data">响应数据</param>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        
        public static HttpResponseType<T> Success<T>(T data, string msg = "成功")
        {
            return new HttpResponseType<T>()
            {
                code = HttpResponseTypeCode.Success,
                message = msg,
                data = data
            };
        }

        /// <summary>
        /// 失败响应快读构造方法
        /// </summary>
        /// <typeparam name="T">响应数据类型</typeparam>
        /// <param name="msg">提示信息</param>
        /// <param name="code">状态码</param>
        /// <returns></returns>
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

