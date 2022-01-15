namespace HuesCluesAndBlazor.Shared.Enums;

public enum WaitingState : byte
{
    NotReady,
    Ready,
    Playing
}

public enum InGameState : byte
{
    Current,
    Idle
}

public enum DealerState : byte 
{
    Dealer,
    Player
}
