﻿namespace ShoppingCartApp
{
    // A class that represents a shopping cart.
    public class ShoppingCart
    {
        // Fields to include:
        // The products in the shopping cart.
        private Product[] products;
        // The number of items in the shopping cart.
        private int itemCount;

        // Properties to include:
        // Gets the array of products in the shopping cart.
        public Product[] Products { get { return products; } }
        // Gets the number of items in the shopping cart.
        public int ItemCount { get { return itemCount; } }

        // Constructors
        // Creates a new instance of the ShoppingCart class with the specified capacity.
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }
        
        // Methods
        // Adds a product to the shopping cart.
        public void AddProduct(Product product)
        {
            products[itemCount] = product;
            itemCount++;
            Console.WriteLine(product.Name + " added to the shopping cart.");
        }

        // Removes a product from the shopping cart.
        /*
         * Code attribution
         * Jon Schneider
         * answered Sep 11, 2014 at 18:00
         * LINQ one-line solution:
         * https://stackoverflow.com/questions/457453/remove-element-of-a-regular-array
         */
        public void RemoveProduct(Product product)
        {
            int temp = products.Length;
            products = products.Where(p => p != product).ToArray();
            if (temp != products.Length)
            {
                itemCount--;
                Console.WriteLine(product.Name + " removed from the shopping cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the shopping cart.");
            }
        }
    }
}
