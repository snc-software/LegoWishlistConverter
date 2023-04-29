namespace LegoWishlistDownloader.Contracts;

public record WishlistLineResponse
{
    public int SetNumber { get; init; }
    public string Name { get; init; }
    public double Price { get; set; }
}