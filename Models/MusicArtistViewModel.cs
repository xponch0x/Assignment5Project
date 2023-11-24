using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace Assignment5Project.Models
{
    public class MusicArtistViewModel
    {
        public List<Music>? Musics { get; set; }
        public SelectList? Artists { get; set; }
        public string? MusicArtist { get; set; }
        public string? SearchString { get; set; }

    }
}
