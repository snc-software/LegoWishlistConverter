namespace LegoWishlistDownloader.Contracts;

public record Product
{
    public Guid Id { get; init; }
    public int ProductCode { get; init; }
    public string Name { get; init; }
    public string Slug { get; init; }
}