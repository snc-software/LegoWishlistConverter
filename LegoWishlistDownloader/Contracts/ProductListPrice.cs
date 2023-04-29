namespace LegoWishlistDownloader.Contracts;

public record ProductListPrice
{
    public string FormattedAmount { get; init; }
    public int CentAmount { get; init; }
}