using Microsoft.AspNetCore.Mvc;
using HuesCluesAndBlazor.Shared;
using HuesCluesAndBlazor.Shared.Models;

namespace HuesCluesAndBlazor.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoardController : ControllerBase
{
    private readonly ILogger<BoardController> _logger;
    private readonly IGameService gameService;

    public BoardController(ILogger<BoardController> logger, IGameService gameService)
    {
        _logger = logger;
        this.gameService = gameService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(gameService.GameState.Board);
    }
}
