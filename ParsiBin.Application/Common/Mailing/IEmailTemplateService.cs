using ParsiBin.Application.Common.Interfaces;

namespace ParsiBin.Application.Common.Mailing
{
    public interface IEmailTemplateService : ITransientService
    {
        string GenerateEmailTemplate<T>(string templateName, T mailTemplateModel);
    }
}
