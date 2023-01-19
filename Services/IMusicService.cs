using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCRUD.Models;

namespace DotNetCRUD.Services;

public interface IMusicService
{
    Task<bool> CreateMusic(Music music);
    Task<Playlist> GetMusic(int id);
    Task<List<Playlist>> GetMusicList();
    Task<Playlist> UpdateMusic(Music music);
    Task<bool> DeleteMusic(int key);

}