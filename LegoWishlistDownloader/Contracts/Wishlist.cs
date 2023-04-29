namespace LegoWishlistDownloader.Contracts;

public record Wishlist
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; init; }
    public DateTime LastModifiedAt { get; init; }
    public int Version { get; init; }
    public WishlistLine[] LineItems { get; set; }
}