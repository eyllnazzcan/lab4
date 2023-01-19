namespace DotNetCRUD.Models;

public class Playlist
{
    public Playlist(Music test1)
    {
    }

    public int Id { get; set; }
    public string PlaylistName { get; set; } = null!;
    public string AlbumName { get; set; } = null!;
    public string SingerName { get; set; } = null!;
    public string Genre { get; set; } = null!;
}