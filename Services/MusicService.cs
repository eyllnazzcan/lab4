using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCRUD.Models;

namespace DotNetCRUD.Services;

public class MusicService : IMusicService
{
    private readonly IDbService _dbService;

    public MusicService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<bool> CreateMusic(Music music)
    {
        var result =
            await _dbService.EditData(
                "INSERT INTO public.Music (id,playlistname) VALUES (@Id, @PlaylistName)",
                music);
        return true;
    }

    public async Task<List<Music>> GetMusicList()
    {
        var musicList = await _dbService.GetAll<Music>("SELECT * FROM public.Music", new { });
        return musicList;
    }


    public async Task<Music> GetMusic(int id)
    {
        var musicList = await _dbService.GetAsync<Music>("SELECT * FROM public.Music where id=@id", new { id });
        return musicList;
    }

    public async Task<Music> UpdatePlaylist(Music music)
    {
        var updateMusic =
            await _dbService.EditData(
                "Update public.music SET playlistname=@PlaylistName WHERE id=@Id",
                music);
        return music;
    }

    public async Task<bool> DeleteMusic (int id)
    {
        var deleteMusic = await _dbService.EditData("DELETE FROM public.music WHERE id=@Id", new { id });
        return true;
    }

    Task<Playlist> IMusicService.GetMusic(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<Playlist>> IMusicService.GetMusicList()
    {
        throw new NotImplementedException();
    }

    public Task<Playlist> UpdateMusic(Music music)
    {
        throw new NotImplementedException();
    }
}