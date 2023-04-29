using LegoWishlistDownloader.Contracts;

namespace LegoWishlistDownloader.Services;

public interface IMultiWishlistConverter
{
    WishlistLineResponse[] Convert(IEnumerable<WishlistRequest> wishlists);
}