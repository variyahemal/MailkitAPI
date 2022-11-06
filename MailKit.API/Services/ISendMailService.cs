using MailKit.API.Models;

namespace MailKit.API.Services
{
    public interface ISendMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
