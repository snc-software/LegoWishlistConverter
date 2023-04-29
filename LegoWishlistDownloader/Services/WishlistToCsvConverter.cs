using System.Text;
using LegoWishlistDownloader.Contracts;
using ServiceStack;

namespace LegoWishlistDownloader.Services;

public class WishlistToCsvConverter : IWishlistToCsvConverter
{
    public Stream Convert(WishlistLineResponse[] wishlistLines)
    { 
        var stream = new MemoryStream(); 
        var writer = new StreamWriter(stream);
        var csv = wishlistLines.ToCsv();
        csv = csv.Replace("™", " TM");
        writer.Write(csv);
        writer.Flush();
        stream.Position = 0;
        return stream;
    }
}