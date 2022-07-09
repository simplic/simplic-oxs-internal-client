using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Auth.InternalClient
{
    public class InternalOrganizationClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalOrganizationClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        internal async Task<IList<Model.InternalOrganizationModel>?> GetForCurrentUser()
        {
            try
            {
                return await Get<IList<Model.InternalOrganizationModel>?>("organization", "InternalOrganization", "get-all");
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal organization call InternalOrganizationClient.GetForCurrentUser", ex);
                return new List<Model.InternalOrganizationModel>();
            }
        }
    }
}
