using Luck.WebSocket.Server;
using Luck.WebSocket.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddWebSocketConfigRouterEndpoint(x =>
{

    x.WebSocketChannels = new Dictionary<string, WebSocketRouteOption.WebSocketChannelHandler>()
                {
                    { "/im",new MvcChannelHandler(4*1024).ConnectionEntry}
                };
    x.ApplicationServiceCollection = builder.Services;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region WebSocket
var webSocketOptions = new WebSocketOptions()
{
    KeepAliveInterval = TimeSpan.FromSeconds(15),
    ReceiveBufferSize = 4 * 1024 
};
app.UseWebSockets(webSocketOptions);
app.UseWebSocketServer(app.Services);
#endregion


app.UseAuthorization();

app.MapControllers();

app.Run();
