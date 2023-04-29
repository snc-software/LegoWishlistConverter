using LegoWishlistDownloader.Contracts;
using LegoWishlistDownloader.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();

builder.Services.AddTransient<IWishlistConverter, WishlistConverter>();
builder.Services.AddTransient<IMultiWishlistConverter, MultiWishlistConverter>();
builder.Services.AddTransient<IWishlistToCsvConverter, WishlistToCsvConverter>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/convert", (
    [FromBody] WishlistRequest wishlist,
    [FromQuery] bool csv,
    IWishlistConverter service,
    IWishlistToCsvConverter csvConverter) =>
{
    var converted = service.Convert(wishlist);
    if (!csv) return Results.Ok(converted);
    var valueAsCsv = csvConverter.Convert(converted);
    return Results.Stream(valueAsCsv, "text/csv", $"LegoWishList-{DateTime.UtcNow:s}");
});


app.MapPost("/convert-many", (
    [FromBody]WishlistRequest[] wishlists,
    [FromQuery]bool csv,
    IMultiWishlistConverter service,
    IWishlistToCsvConverter csvConverter) =>
{
    var converted = service.Convert(wishlists);
    if (!csv) return Results.Ok(converted);
    var valueAsCsv = csvConverter.Convert(converted);
    return Results.Stream(valueAsCsv, "text/csv", $"LegoWishList-{DateTime.UtcNow:s}");
});

app.Run();