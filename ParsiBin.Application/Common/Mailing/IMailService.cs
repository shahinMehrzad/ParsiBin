using ParsiBin.Application.Common.Interfaces;

namespace ParsiBin.Application.Common.Mailing
{
    public interface IMailService : ITransientService
    {
        Task SendAsync(MailRequest request);
    }
}
