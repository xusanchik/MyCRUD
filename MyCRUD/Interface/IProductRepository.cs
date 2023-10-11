using MyCRUD.Models.cs;

namespace MyCRUD.Interface;
public interface IProductRepository
{
    Task<List<Product>> GetProductsAll();
    Task<Product> GetId(int id);
    Task<Product> UpdateProduct(int id,Product product);
    Task  DeteleProduct (int id);
}
