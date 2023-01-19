using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCRUD.Models;

namespace DotNetCRUD.Services;

public class PlaylistService : IPlaylistService
{
    private readonly IDbService _dbService;

    public PlaylistService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<bool> CreatePlaylist(Playlist playlist)
    {
        var result =
            await _dbService.EditData(
                "INSERT INTO public.playlist (id,playlistname, albumname, singername, genre) VALUES (@Id, @PlaylistName, @AlbumName, @SingerName, @Genre)",
                playlist);
        return true;
    }

    public async Task<List<Playlist>> GetPlaylistList()
    {
        var playlistList = await _dbService.GetAll<Playlist>("SELECT * FROM public.playlist", new { });
        return playlistList;
    }


    public async Task<Playlist> GetPlaylist(int id)
    {
        var playlistList = await _dbService.GetAsync<Playlist>("SELECT * FROM public.playlist where id=@id", new { id });
        return playlistList;
    }

    public async Task<Playlist> UpdatePlaylist(Playlist playlist)
    {
        var updatePlaylist =
            await _dbService.EditData(
                "Update public.playlist SET playlistname=@PlaylistName, albumname=@AlbumName, singername=@SingerName, genre=@Genre WHERE id=@Id",
                playlist);
        return playlist;
    }

    public async Task<bool> DeletePlaylist(int id)
    {
        var deletePlaylist = await _dbService.EditData("DELETE FROM public.playlist WHERE id=@Id", new { id });
        return true;
    }
}