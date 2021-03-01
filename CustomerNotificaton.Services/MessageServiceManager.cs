using CustomerNotification.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerNotificaton.Services
{
    public class MessageServiceManager
    {
        public static IServiceBase serviceBase;
        public static MessageFormat MessageFormatType = MessageFormat.None;
        public static MessagingServiceType MessagingServiceType = MessagingServiceType.None;

        public static void GetSettings()
        {
            // Read this settings from the database for the specific customer. 
            // CustomerId: 12 - MessagingServiceType: Http - MessageFormatType: Json
            // CustomerId: 13 - MessagingServiceType: Ftp  - MessageFormatType: Csv
            // CustomerId: 14 - MessagingServiceType: Sms  - MessageFormatType: Xml

            // As of now we are putting the static values.
            MessageFormatType = MessageFormat.Json;
            MessagingServiceType = MessagingServiceType.Ftp;
        }

        public static IServiceBase GetMessagingService()
        {
            switch (MessagingServiceType)
            {
                case MessagingServiceType.None:
                    break;
                case MessagingServiceType.Ftp:
                    serviceBase = new FtpMessagingService() { MessageFormat = MessageFormatType };
                    break;
                case MessagingServiceType.Http:
                    serviceBase = new HttpMessagingService() { MessageFormat = MessageFormatType };
                    break;
                case MessagingServiceType.Sms:
                    serviceBase = new SmsMessagingService() { MessageFormat = MessageFormatType };
                    break;
                default:
                    break;
            }

            return serviceBase;
        }
    }
}
