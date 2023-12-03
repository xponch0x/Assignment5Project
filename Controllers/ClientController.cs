using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment5Project.Data;
using Assignment5Project.Models;

namespace Assignment5Project.Controllers
{
    public class ClientController : Controller
    {
        private readonly Assignment5ProjectContext _context;

        public ClientController(Assignment5ProjectContext context)
        {
            _context = context;
        }

        // GET: Client
        public async Task<IActionResult> Index(string musicGenre, string musicArtist, string searchString)
        {
            if (_context.Music == null)
            {
                return Problem("Entity set 'Assignment5ProjectContext.Music'  is null.");
            }

            //use linq query to get list of genres
            IQueryable<string> genreQuery = from m in _context.Music
                                            orderby m.Genre
                                            select m.Genre;


            var music = from m in _context.Music
                        select m;

            //checks if strings are null
            if (!string.IsNullOrEmpty(searchString))
            {
                music = music.Where(s => s.Title!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(musicArtist))
            {
                music = music.Where(s => s.Artist!.Contains(musicArtist));
            }

            if (!string.IsNullOrEmpty(musicGenre))
            {
                music = music.Where(x => x.Genre == musicGenre);
            }



            var musicGenreVM = new MusicGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Musics = await music.ToListAsync()

            };

            return View(musicGenreVM);
        }

        // GET: Client/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Music == null)
            {
                return NotFound();
            }

            var music = await _context.Music
                .FirstOrDefaultAsync(m => m.Id == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }
        public IActionResult MyCart()
        {
            return View();
        }

    }
}
