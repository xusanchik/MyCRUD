using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyCRUD.Interface;
using MyCRUD.Models.cs;
using MyCRUD.Repastorys;

namespace MyCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepastory;
        public UserController(IUserRepository userRepastory) => _userRepastory = userRepastory;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(_userRepastory.GetAllUsers());
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id) => Ok(_userRepastory.GetById(id));
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user) => Ok(_userRepastory.CreateUser(user));
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int  id,User user) => Ok(_userRepastory.UpdateUser(id,user));
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id) => Ok(DeleteUser(id));
        

    }
}
