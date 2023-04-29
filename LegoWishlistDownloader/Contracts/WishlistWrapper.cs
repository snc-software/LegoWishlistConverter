using System.Text.Json.Serialization;

namespace LegoWishlistDownloader.Contracts;

public record WishlistWrapper
{
    [JsonPropertyName("listGetById")]
    public Wishlist Wishlist { get; init; }
}