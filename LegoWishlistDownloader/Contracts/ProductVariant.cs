namespace LegoWishlistDownloader.Contracts;

public record ProductVariant
{
    public ProductPrice Price { get; init; }
    public ProductListPrice ListPrice { get; init; }
}