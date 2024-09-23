﻿using Microsoft.EntityFrameworkCore;
using MovieOrganizer.Data;
using MovieOrganizer.Models.Domain;

namespace MovieOrganizer.Repositories
{
    
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDBContext movieDBContext;

        public MovieRepository(MovieDBContext movieDBContext)
        {
            this.movieDBContext = movieDBContext;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await movieDBContext.Movies.ToListAsync();
        }

        public async Task<Movie?> CreateAsync(Movie movie)
        {
            await movieDBContext.AddAsync(movie);
            await movieDBContext.SaveChangesAsync();
            return movie;
        }
    }
}