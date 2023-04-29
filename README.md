# LegoWishlistConverter

Get your wishlists from lego and return a friendly list. 

This can be used to compare your wanted sets against sets retiring sets from sites such as https://www.brickfanatics.com/every-lego-set-retiring-in-2023-april so that you never miss out on a set again!

# Get your wishlist from lego 
1. Go to your wishlist in lego - https://www.lego.com/en-gb/my-account/wishlist and select the wishlist you want to export
2. Open up the developer toolbox (this is F12 in google chrome) 
3. Open the Network tab and ensure Fetch/XHR is selected
4. Look in the list for 'GetWishlistById' (refresh your page if this is not in the list)
5. Click on the 'GetWishlistById' request and open the 'Response' tab.
6. Copy the entire content

7. Open up the app and run 
8. find the 'Convert' endpoint and paste the content copied from step 6 as your request body. 

This will return a response with the properties 
SetNumber, Name, Price 

#To convert many 
Copy steps 1 through 6 and paste each content as an array object into the request body of 'convert-many' endpoint

#To get CSV
Send a true value for csv and the endpoint will return a csv file.
