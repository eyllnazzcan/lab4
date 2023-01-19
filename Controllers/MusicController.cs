using System.Threading.Tasks;
using DotNetCRUD.Models;
using DotNetCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class MusicController : Controller
{
    private readonly IMusicService _musicService;

    public MusicController(IMusicService musicService)
    {
        _musicService = musicService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _musicService.GetMusicList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMusic(int id)
    {
        var result = await _musicService.GetMusic(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddMusic([FromBody] Music music)
    {
        var result = await _musicService.CreateMusic(music);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateMusic([FromBody] Music music)
    {
        var result = await _musicService.UpdateMusic(music);

        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteMusic(int id)
    {
        var result = await _musicService.DeleteMusic(id);

        return Ok(result);
    }
}