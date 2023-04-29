using LegoWishlistDownloader.Contracts;

namespace LegoWishlistDownloader.Services;

public class MultiWishlistConverter : IMultiWishlistConverter
{
    readonly IWishlistConverter _wishlistConverter;

    public MultiWishlistConverter(IWishlistConverter wishlistConverter)
    {
        _wishlistConverter = wishlistConverter;
    }

    public WishlistLineResponse[] Convert(IEnumerable<WishlistRequest> wishlists)
    {
        var wishlistLines = new List<WishlistLineResponse>();

        foreach (var wishlist in wishlists)
        {
            wishlistLines.AddRange(_wishlistConverter.Convert(wishlist));
        }

        return wishlistLines.DistinctBy(p => p.SetNumber).ToArray();
    }
}