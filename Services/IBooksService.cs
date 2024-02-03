using BookStore.Models;

namespace BookStore.Services;

public interface IBooksService
{
    Task<List<Book>> GetAllBooksAsync();
}
