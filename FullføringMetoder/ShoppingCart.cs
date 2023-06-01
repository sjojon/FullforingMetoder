namespace FullføringMetoder
{
    internal class ShoppingCart
    {
        private List<Product> Products { get; set; }

        public ShoppingCart(List<Product> products)
        {
            Products = products;
        }

        public void AddProduct(Product product)
        {
            // TODO: Legg til produktet i handlekurven
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            // TODO: Fjern produktet fra handlekurven
            Products.Remove(product);
        }

        public decimal CalculateTotalPrice()
        {
            // TODO: Beregn den totale prisen for alle produktene i handlekurven
            // og returner prisen som en decimal-verdi
            decimal totalPrice = 0;

            foreach (var product in Products)
                totalPrice += product.Price;

            return totalPrice;
        }

        public List<Product> GetProducts()
        {
            // TODO: Returner listen over produkter i handlekurven
            var products = new List<Product>();

            foreach (var product in Products)
                products.Add(product);

            return products;
        }
    }
}