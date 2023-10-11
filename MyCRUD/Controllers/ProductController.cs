using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCRUD.Interface;
using MyCRUD.Models.cs;
using MyCRUD.Repastorys;

namespace MyCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepastory;
        public ProductController(IProductRepository productRepastory) => _productRepastory = productRepastory;
        [HttpGet]
        public async Task<IActionResult> GatAll() => Ok(_productRepastory.GetProductsAll());
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id,Product product) => Ok(_productRepastory.UpdateProduct(id,product));
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id) => Ok(_productRepastory.DeteleProduct(id));

    }
}
