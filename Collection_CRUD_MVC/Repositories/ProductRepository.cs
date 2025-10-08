using Collection_CRUD_MVC.Models;


namespace Collection_CRUD_MVC.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product{ProductId=1, Name="Chocolate", Price=200},
            new Product{ProductId=2, Name="Biscuit", Price=120},
            new Product{ProductId=3, Name="Shampoo", Price=120},
            new Product{ProductId=4, Name="Soap", Price=80},

        };

        public void AddNewProduct(Product product)
        {
            products.Add(product);
        }
        public void UpdateProductByPrice(int produtId, double price)
        {
            Product product=products.FirstOrDefault(x=> x.ProductId==produtId);
            if (product != null)
            {
                product.Price = price;
            }
        }

        public Product GetProduct(int productId)
        {
            Product product=products.FirstOrDefault(x=> x.ProductId==productId);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void DeleteProduct(int productId)
        {
            Product product=products.FirstOrDefault(x=> x.ProductId==productId);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
