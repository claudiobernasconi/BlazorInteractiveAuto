using BlazorInteractiveAuto.Client.Models;

namespace BlazorInteractiveAuto.Client.Services;

public interface ISalesService
{
    Task<IReadOnlyList<Sale>> GetSalesAsync(CancellationToken cancellationToken = default);
}
