using Microsoft.AspNetCore.Authorization;
using ParsiBin.SharedKernel.Authorization;

namespace ParsiBin.Infrastructure.Auth.Permissions
{
    public class MustHavePermissionAttribute : AuthorizeAttribute
    {
        public MustHavePermissionAttribute(string action, string resource) =>
            Policy = ParsiBinPermission.NameFor(action, resource);
    }
}
