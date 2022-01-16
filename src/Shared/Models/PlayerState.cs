using HuesCluesAndBlazor.Shared.Enums;

namespace HuesCluesAndBlazor.Shared.Models;

public class PlayerAndState
{
    public string Id { get; set; }
    public string Name { get; set; }
    public DealerState Delaler { get; set; }
    public WaitingState Waiting { get; set; }
    public InGameState InGameState { get; set; }
    public int Points { get; set; }
}