using Collection_CRUD_MVC.Models;

namespace Collection_CRUD_MVC.Repositories
{
    public interface IProductRepository
    {
        void AddNewProduct(Product product);
        void UpdateProductByPrice(int productId, double price);
        Product GetProduct(int productId);
        List<Product> GetAllProducts();
        void DeleteProduct(int productId);
    }
}
