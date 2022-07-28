using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Organization.InternalClient.Model;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Organization.InternalClient
{
    public class InternalOrganizationSiteClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalOrganizationSiteClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<OrganizationSiteInternalModel?> GetById(Guid id)
        {
            try
            {
                return await Get<OrganizationSiteInternalModel?>("organization", "InternalOrganizationSite", $"{id}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Could make internal organization call InternalOrganizationClient.Get/{id}", ex);
                return null;
            }
        }

        public async Task<IList<Model.OrganizationSiteInternalModel>?> GetAllByOrganization(Guid organizationId)
        {
            try
            {
                return await Get<IList<Model.OrganizationSiteInternalModel>?>("organization", "InternalOrganizationSite", "get-all-by-organization", new Dictionary<string, string> 
                {
                    { "id", organizationId.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal organization call InternalOrganizationClient.GetAllByOrganization", ex);
                return new List<Model.OrganizationSiteInternalModel>();
            }
        }
    }
}