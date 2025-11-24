using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Organization.InternalClient
{
    public class InternalOrganizationClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalOrganizationClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<IList<Model.OrganizationMemberModel>?> GetForCurrentUser()
        {
            try
            {
                return await Get<IList<Model.OrganizationMemberModel>?>("organization", "InternalOrganization", "get-all");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not make internal organization call InternalOrganizationClient.GetForCurrentUser");
                return new List<Model.OrganizationMemberModel>();
            }
        }

        public async Task<Model.OrganizationModel?> GetCurrent()
        {
            try
            {
                return await Get<Model.OrganizationModel>("organization", "InternalOrganization", "get-current");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Could not make internal organization call InternalOrganizationClient.GetCurrent.");
                return null;
            }
        }

        public async Task<IList<Model.OrganizationMemberModel>?> GetUsersForOrganization()
        {
            try
            {
                return await Get<IList<Model.OrganizationMemberModel>?>("organization", "InternalOrganization", "get-users");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not make internal organization call " +
                    "InternalOrganizationCLient.GetUsersForOrganization");
                return new List<Model.OrganizationMemberModel>();
            }
        }

        public async Task<IList<Guid>?> GetAllOrganizationIds()
        {
            try
            {
                return await Get<IList<Guid>>("organization", "InternalOrganization", "get-all-ids");
            }
            catch (Exception ex)
            {
                logger.LogError(ex,"Could not make internal organization call " +
                    "InternalOrganizationClient.GetAllOrganizationIds");
                return new List<Guid>();
            }
        }
    }
}