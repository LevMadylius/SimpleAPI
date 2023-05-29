using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Random _random;
        public TestController()
        {
            _random = new Random();
        }
        [HttpGet]
        public Task<string> Get() => Task.FromResult("test");

        [HttpGet]
        [Route("random")]
        public Task<int> Get(int number) => Task.FromResult(_random.Next(0, number));
    }
}
