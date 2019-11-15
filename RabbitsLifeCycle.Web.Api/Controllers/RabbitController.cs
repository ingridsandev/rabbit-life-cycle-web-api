using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitsLifeCycle.Web.Api.Services;

namespace RabbitsLifeCycle.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class RabbitController : Controller
    {
        private readonly IRabbitService _rabbitService;
        public RabbitController(IRabbitService rabbitService) =>
            _rabbitService = rabbitService;
        
        [HttpPost("count")]
        public async Task<ObjectResult> CountAsync(int month) =>
            await _rabbitService.CountAsync(month);
    }
}
