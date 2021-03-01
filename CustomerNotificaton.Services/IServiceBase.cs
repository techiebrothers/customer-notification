using CustomerNotification.Domain;
using System.Threading.Tasks;

public interface IServiceBase
{
    MessageFormat MessageFormat { get; set; }
    Task SendMessageAsync(string customerId, string messageBody);
}