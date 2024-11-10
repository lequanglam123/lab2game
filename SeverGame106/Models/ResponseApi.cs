using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace SeverGame106.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseApi : ControllerBase
    {
        public bool IsSuccess { get; set; } = true;
        public string Notification { get; set; }
        public object Data { get; set; }
    }
} 
