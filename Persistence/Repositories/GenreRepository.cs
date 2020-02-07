using GigHub.Core.Models;
using GigHub.Core.Repositories;
using GigHub.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}