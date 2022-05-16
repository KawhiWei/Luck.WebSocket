using Microsoft.AspNetCore.Http;

namespace Luck.WebSocket.Server
{
    public interface IWebSocketSession
    {

        /// <summary>
        /// 当前请求的HttpContext
        /// Current request http context
        /// </summary>
        public HttpContext WebSocketHttpContext { get; set; }

        /// <summary>
        /// 当前链接的WebSocket信息
        /// Current session web socket client
        /// </summary>
        public System.Net.WebSockets.WebSocket WebSocketClient { get; set; }
    }
}