using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCRUD.Models;

namespace DotNetCRUD.Services;

public interface IPlaylistService
{
    Task<bool> CreatePlaylist(Playlist playlist);
    Task<Playlist> GetPlaylist(int id);
    Task<List<Playlist>> GetPlaylistList();
    Task<Playlist> UpdatePlaylist(Playlist playlist);
    Task<bool> DeletePlaylist(int key);

}