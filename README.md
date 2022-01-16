# Hues Clues And Blazor

a simple board game [Hues and Clues](https://theop.games/products/game/hues-and-cues/) implemented with [Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-6.0).
If you like the game follow the link and buy the original.

## Development

```sh
cd src/Server

# build
dotnet build

# run
dotnet run
```

# Usage (at the moment)

1. host/deploy the game somewhere
2. gather some friends in a zoom, gmeet, whatever call so you can talk to eachother
3. open the URL of the hosted game (localhost:7126/board if you run locally)
4. enter your name and join the game (your friends too)
5. first player (dealer) picks a color and shares a clue about it
6. other players one by one pick a cell on the board
7. dealer reveals the right cell distributes points
8. change dealer, repeat from point 5

# Milestones

- [x] Join game with name
- [x] Show names and clicks real time
- [ ] Enforce game rules
- [ ] Lobby
- [ ] Settings
- [ ] Calculate points
- [ ] Player guide
