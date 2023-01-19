using System.Threading.Tasks;
using DotNetCRUD.Models;
using DotNetCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistController : Controller
{
    private readonly IPlaylistService _playlistService;

    public PlaylistController(IPlaylistService playlistService)
    {
        _playlistService = playlistService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _playlistService.GetPlaylistList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPlaylist(int id)
    {
        var result = await _playlistService.GetPlaylist(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddPlaylist([FromBody] Playlist playlist)
    {
        var result = await _playlistService.CreatePlaylist(playlist);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePlaylist([FromBody] Playlist playlist)
    {
        var result = await _playlistService.UpdatePlaylist(playlist);

        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeletePlaylist(int id)
    {
        var result = await _playlistService.DeletePlaylist(id);

        return Ok(result);
    }
}