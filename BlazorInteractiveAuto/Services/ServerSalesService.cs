using BlazorInteractiveAuto.Client.Models;
using BlazorInteractiveAuto.Client.Services;

namespace BlazorInteractiveAuto.Services;

public class ServerSalesService : ISalesService
{
    private static readonly List<Sale> Sales =
    [
        new() { Id = 1, Customer = "Acme Corp", Product = "Laptop", Region = "North", Date = new(2026, 10, 2), Amount = 2450, Status = "Completed" },
        new() { Id = 2, Customer = "Globex", Product = "Monitor", Region = "West", Date = new(2026, 10, 4), Amount = 890, Status = "Pending" },
        new() { Id = 3, Customer = "Initech", Product = "Keyboard", Region = "East", Date = new(2026, 10, 5), Amount = 320, Status = "Completed" },
        new() { Id = 4, Customer = "Umbrella", Product = "Laptop", Region = "South", Date = new(2026, 10, 7), Amount = 3100, Status = "Completed" },
        new() { Id = 5, Customer = "Stark Industries", Product = "Monitor", Region = "North", Date = new(2026, 10, 9), Amount = 1250, Status = "Pending" },
        new() { Id = 6, Customer = "Wayne Enterprises", Product = "Laptop", Region = "West", Date = new(2026, 10, 10), Amount = 4200, Status = "Completed" },
        new() { Id = 7, Customer = "Hooli", Product = "Keyboard", Region = "East", Date = new(2026, 10, 12), Amount = 450, Status = "Cancelled" },
        new() { Id = 8, Customer = "Pied Piper", Product = "Monitor", Region = "South", Date = new(2026, 10, 14), Amount = 780, Status = "Completed" },
        new() { Id = 9, Customer = "Acme Corp", Product = "Laptop", Region = "North", Date = new(2026, 10, 16), Amount = 2750, Status = "Completed" },
        new() { Id = 10, Customer = "Globex", Product = "Keyboard", Region = "West", Date = new(2026, 10, 18), Amount = 390, Status = "Pending" },
        new() { Id = 11, Customer = "Initech", Product = "Monitor", Region = "East", Date = new(2026, 10, 20), Amount = 1100, Status = "Completed" },
        new() { Id = 12, Customer = "Umbrella", Product = "Laptop", Region = "South", Date = new(2026, 10, 22), Amount = 3500, Status = "Cancelled" }
    ];

    public Task<IReadOnlyList<Sale>> GetSalesAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IReadOnlyList<Sale>>(Sales);
    }
}
