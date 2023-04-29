using LegoWishlistDownloader.Contracts;

namespace LegoWishlistDownloader.Services;

public class WishlistConverter : IWishlistConverter
{
    public WishlistLineResponse[] Convert(WishlistRequest wishlist)
    {
        var wishlistLines = wishlist?.Wrapper?.Wishlist?.LineItems;
        if (wishlistLines is null || wishlistLines.Length == 0)
        {
            return Array.Empty<WishlistLineResponse>();
        }

        return wishlistLines.Select(line => new WishlistLineResponse
        {
            SetNumber = line.Product.ProductCode,
            Name = line.Product.Name,
            Price = line.ProductVariant.ListPrice.CentAmount * 0.01,
        }).ToArray();
    }
}