using System.Threading.Tasks;

namespace CarRental.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailConfirmationAsync(string email, string link);
    }
}
