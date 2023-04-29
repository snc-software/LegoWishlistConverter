using System.Text.Json.Serialization;

namespace LegoWishlistDownloader.Contracts;

public class WishlistRequest
{
    [JsonPropertyName("data")]
    public WishlistWrapper Wrapper { get; init; }
}