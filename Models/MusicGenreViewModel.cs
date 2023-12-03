using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace Assignment5Project.Models
{
    public class MusicGenreViewModel
    {
        //view model for dropdown list
        public List<Music>? Musics { get; set; }
        public SelectList? Genres { get; set; }
        public string? MusicGenre { get; set; } 
        public string? SearchString { get; set; }

    }
}
