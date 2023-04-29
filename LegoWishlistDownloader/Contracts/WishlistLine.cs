namespace LegoWishlistDownloader.Contracts;

public record WishlistLine
{
    public Guid Id { get; init; }
    public Product Product { get; init; }
    public ProductVariant ProductVariant { get; init; }
}