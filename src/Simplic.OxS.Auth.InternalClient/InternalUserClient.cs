using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Auth.InternalClient
{
    public class InternalUserClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalUserClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<Model.RequestUserResponse?> GetUserByEmail(string email)
        {
            try
            {
                return await Get<Model.RequestUserResponse?>("auth", "InternalUser", "get-by-email", new Dictionary<string, string>
                {
                    { "email", email }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal auth/user call InternalUserClient.GetUserByEmail", ex);
                return null;
            }
        }

        public async Task<Model.RequestUserResponse?> GetUserById(Guid id)
        {
            try
            {
                return await Get<Model.RequestUserResponse?>("auth", "InternalUser", "get-by-id", new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Could make internal auth/user call InternalUserClient.GetUserById", ex);
                return null;
            }
        }
    }
}