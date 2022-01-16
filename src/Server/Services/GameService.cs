using HuesCluesAndBlazor.Shared.Enums;
using HuesCluesAndBlazor.Shared.Models;

public interface IGameService {
    GameState GameState { get; set; }

    void AddPlayer(PlayerAndState player);
    void AddNewPlayer(string name);
    void RemovePlayer(PlayerAndState player);
    void RemovePlayerById(string id);
    void RegisterPlayerMove(PlayerAndState player, int x, int y);
    void DealNewTurn();
    void CalculateScore();
}

public class GameService : IGameService
{
    public GameState GameState { get; set; }

    public GameService() 
    {
        GameState = new GameState 
        {
            Board = new List<List<string>>(),
            Players = new List<PlayerAndState>()
        };
    }

    public void AddPlayer(PlayerAndState player)
    {
        throw new NotImplementedException();
    }

    public void AddNewPlayer(string connectionId) 
    {
        var newPlayer = new PlayerAndState 
        {
            Name = "",
            Id = connectionId,
            Delaler = GameState.Players.Count == 0 ? DealerState.Dealer : DealerState.Player,
            Waiting = WaitingState.NotReady,
            InGameState = InGameState.Idle,
            Points = 0
        };

        GameState.Players.Add(newPlayer);
    }

    public void CalculateScore()
    {
        throw new NotImplementedException();
    }

    public void DealNewTurn()
    {
        throw new NotImplementedException();
    }

    public void RegisterPlayerMove(PlayerAndState player, int x, int y)
    {
        throw new NotImplementedException();
    }

    public void RemovePlayer(PlayerAndState player)
    {
        throw new NotImplementedException();
    }

    public void RemovePlayerById(string id)
    {
        var player = GameState.Players
            .Where(p => p.Id == id)
            .First();

        GameState.Players.Remove(player);
    }
}