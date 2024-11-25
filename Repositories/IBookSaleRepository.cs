using Bai6.Models;

namespace Bai6.Repositories;
public interface IBookSaleRepository
{
    Task AddNewSale(Test1 bookSale);
}