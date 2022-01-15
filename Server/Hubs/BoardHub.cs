using System.Threading.Tasks;
using HuesCluesAndBlazor.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace HuesCluesAndBlazor.Server.Hubs
{
    public class BoardHub : Hub
    {
        private readonly IGameService _game;

        public BoardHub(IGameService gameService) : base () {
            this._game = gameService;
        }
        
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync(MessageTypes.ReceiveMessage, user, message);
        }

        public async Task ServerSyncUpdate(GameState newState) {
            // TODO sync state in a clever way
            _game.GameState = newState;

            await Clients.All.SendAsync(MessageTypes.ClientHandleUpdate, _game.GameState, Context.ConnectionId);
        }

        public override async Task OnConnectedAsync()
        {
            // add user to game
            _game.AddNewPlayer(Context.ConnectionId);
            // send current game state
            await Clients.Caller.SendAsync(MessageTypes.ClientRegisterName, Context.ConnectionId, _game.GameState);

            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            // TODO remove user
            return base.OnDisconnectedAsync(exception);
        }
    }
}