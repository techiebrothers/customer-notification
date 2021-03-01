using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerNotificaton.Services
{
    public class HttpMessagingService : ServiceBase
    {
        public override async Task SendMessageAsync(string customerId, string messageBody)
        {
            await base.SendMessageAsync(customerId, messageBody);
        }
    }
}
