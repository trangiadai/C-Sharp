using Bai6.Models;
namespace Bai6.Repositories;

public class BookSaleRepository : IBookSaleRepository
{
    private BooksalesContext bookSaleContext;

    public BookSaleRepository(BooksalesContext context)
    {
        this.bookSaleContext = context;
    }

    public async Task AddNewSale(Test1 bookSale)
    {
        this.bookSaleContext.Add(bookSale);
        await this.bookSaleContext.SaveChangesAsync();
    }
}