using LegoWishlistDownloader.Contracts;

namespace LegoWishlistDownloader.Services;

public interface IWishlistConverter
{
    WishlistLineResponse[] Convert(WishlistRequest wishlist);
}