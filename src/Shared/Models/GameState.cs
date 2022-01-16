namespace HuesCluesAndBlazor.Shared.Models;

public class GameState {
    public List<List<string>> Board { get; set; } 
    public List<PlayerAndState> Players { get; set; }
}