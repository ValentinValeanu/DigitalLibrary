﻿using DigitalLibrary.Models.DTOs;

namespace DigitalLibrary.Services.Interfaces
{
    public interface IBooksService
    {
        public Task<List<Book>> GetBooksAsync();

        public Task<Book?> GetBookAsync(int id);

        public Task<Book> AddBookAsync(BookInput book);

        public Task DeleteBookAsync(Book book);
    }
}
