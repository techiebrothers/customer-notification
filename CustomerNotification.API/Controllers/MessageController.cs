using CustomerNotification.API.Model;
using CustomerNotification.Domain;
using CustomerNotificaton.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CustomerNotification.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private IServiceBase messagingService;

        public MessageController(IServiceBase serviceBase)
        {
            this.messagingService = MessageServiceManager.GetMessagingService();
        }

        [Route("register")]
        public async Task<IActionResult> RegisterAsync(User user)
        {
            return Ok(user);
        }

        [Route("delete")]
        public async Task<IActionResult> Delete(int userId)
        {
            return Ok();
        }

        [Route("deactivate")]
        public async Task<IActionResult> Deactivate(int userId)
        {
            return Ok();
        }
    } 
}
