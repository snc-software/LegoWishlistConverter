namespace LegoWishlistDownloader.Contracts;

public record ProductPrice
{
    public string FormattedAmount { get; init; }
    public int CentAmount { get; init; }
    public string CurrencyCode { get; init; }
    public decimal FormattedValue { get; init; }
}