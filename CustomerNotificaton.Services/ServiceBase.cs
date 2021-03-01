using CustomerNotification.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerNotificaton.Services
{
    public class ServiceBase : IServiceBase
    {
        public MessageFormat MessageFormat { get; set; }

        public virtual async Task SendMessageAsync(string customerId, string messageBody)
        {
            //this is a mock method and candidates don't need to chage this
            await Task.Delay(1000);
            Console.WriteLine($"sending customer id: {customerId}, the following message {messageBody}");
        }
    }
}
