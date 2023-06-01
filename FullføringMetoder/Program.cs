using FullføringMetoder;
using System.Collections.Generic;

ShoppingCart shoppingCart = new(new List<Product>());

Product hairspray = new("Hairspray", 9.99M);
Product cologne = new("Cologne", 49.99M);
Product deodorant = new("Deodorant", 14.99M);

shoppingCart.AddProduct(hairspray);
shoppingCart.AddProduct(cologne);
shoppingCart.AddProduct(deodorant);

List<Product> productsInCart = shoppingCart.GetProducts();

foreach (var product in productsInCart)
{
    Console.WriteLine(product.Name);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(shoppingCart.CalculateTotalPrice());