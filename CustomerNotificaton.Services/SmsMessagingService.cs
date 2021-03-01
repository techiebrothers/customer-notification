using System;
using System.Threading.Tasks;

namespace CustomerNotificaton.Services
{
    public class SmsMessagingService : ServiceBase
    {
        public override async Task SendMessageAsync(string customerId, string messageBody)
        {
            await base.SendMessageAsync(customerId, messageBody);
        }
    }
}