using System.Net.Http.Json;
using BlazorInteractiveAuto.Client.Models;

namespace BlazorInteractiveAuto.Client.Services;

public class ClientSalesService(HttpClient httpClient) : ISalesService
{
    public async Task<IReadOnlyList<Sale>> GetSalesAsync(CancellationToken cancellationToken = default)
    {
        return await httpClient.GetFromJsonAsync<Sale[]>("api/sales", cancellationToken) ?? [];
    }
}
