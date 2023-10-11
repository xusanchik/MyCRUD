using Microsoft.EntityFrameworkCore;
using MyCRUD.Data;
using MyCRUD.Interface;
using MyCRUD.Models.cs;

namespace MyCRUD.Repastorys;
public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;
    public ProductRepository(AppDbContext _context)
    {
        _appDbContext = _context;
    }
    public async Task DeteleProduct(int id)
    {
        var product = await _appDbContext.Products.FindAsync(id);
        _appDbContext.Products.Remove(product);
        await _appDbContext.SaveChangesAsync();

    }

    public async Task<Product> GetId(int id)
    {
        var getid = await _appDbContext.Products.FindAsync(id);
        return getid;
    }

    public async Task<List<Product>> GetProductsAll()
    {
        var producs = await _appDbContext.Products.ToListAsync();
        return producs;
    }

    public async Task<Product> UpdateProduct(int id, Product product)
    {
        var oldproduct = await _appDbContext.Products.FindAsync(id);
        oldproduct.Name = product.Name;
        oldproduct.Description = product.Description;
        oldproduct.Price = product.Price;
        await _appDbContext.SaveChangesAsync();
        return oldproduct;
    }
}
