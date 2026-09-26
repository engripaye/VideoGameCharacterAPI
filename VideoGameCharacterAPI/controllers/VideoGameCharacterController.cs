using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoGameCharacterController : ControllerBase
{
    private static List<Character> characters = new List<Character>
    {
        new Character { id = 1, name = "Mr Ping", game = "Ping pong", role = "Actor" },
        new Character { id = 2, name = "Mr Ben", game = "Ben 10", role = "Boss" },
        new Character { id = 3, name = "Mr GTA", game = "GTA VI", role = "Police" }
    };
    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacters()
        => await Task.FromResult(Ok(characters));
}