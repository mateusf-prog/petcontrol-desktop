using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace PetControlSystem.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{v:apiVersion}/orders")]
    public class OrderController
    {
    }
}
