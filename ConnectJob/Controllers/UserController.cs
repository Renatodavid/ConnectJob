using ConnectJob.Data;
using ConnectJob.Models;
using ConnectJob.Repositorys.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConnectJob.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ConnectjobContext _connectjobContext;
        public UserController(ConnectjobContext connectjobContext)
        {
            _connectjobContext = connectjobContext;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetAllusers()
        {
           
            return await _connectjobContext.User.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetSearchById(int id)
        {
            var user = await _connectjobContext.User.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        
    }
}
