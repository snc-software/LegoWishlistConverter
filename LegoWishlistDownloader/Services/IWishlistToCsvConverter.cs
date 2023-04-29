using LegoWishlistDownloader.Contracts;

namespace LegoWishlistDownloader.Services;

public interface IWishlistToCsvConverter
{
    Stream Convert(WishlistLineResponse[] wishlistLines);
}