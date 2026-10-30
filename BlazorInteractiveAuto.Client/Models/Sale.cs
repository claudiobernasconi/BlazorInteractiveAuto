namespace BlazorInteractiveAuto.Client.Models;

public class Sale
{
    public int Id { get; set; }

    public string Customer { get; set; } = string.Empty;

    public string Product { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public string Status { get; set; } = string.Empty;
}
