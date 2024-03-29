﻿using System;

namespace Luck.WebSocket.Server.Attributes
{
    /// <summary>
    /// WebSocket Endpoint mark
    /// WebSocket路由标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class WebSocketAttribute : Attribute
    {
        /// <summary>
        /// Mark action use action name
        /// </summary>
        public WebSocketAttribute()
        {
        }

        /// <summary>
        /// Mark action use method value
        /// </summary>
        /// <param name="method"></param>
        public WebSocketAttribute(string method) : this()
        {
            Method = method;
        }

        /// <summary>
        /// Endpoint method name
        /// </summary>
        public string Method { get; set; }
    }
}
