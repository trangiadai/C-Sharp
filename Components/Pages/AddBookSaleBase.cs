using Bai6.Models;
using Bai6.Repositories;
using Microsoft.AspNetCore.Components;

namespace Bai6.Pages;

public partial class AddBookSaleBase : ComponentBase
{
    // Khởi tạo đối tượng BookSale
    public Test1 bookSale { get; set; } = new Test1();

    // Dependency Injection
    [Inject]
    public IBookSaleRepository bookSalesRepository { get; set; }

    [Inject]
    public NavigationManager navigationManager { get; set; }

    // Phương thức xử lý khi form hợp lệ
    public async Task HandleValidSubmit()
    {
        await bookSalesRepository.AddNewSale(bookSale);
        navigationManager.NavigateTo("/");
    }

    // Phương thức tính toán (trong trường hợp này, gọi trực tiếp đến HandleValidSubmit)
    public async Task Form_Calculate()
    {
        HandleValidSubmit();
    }
}