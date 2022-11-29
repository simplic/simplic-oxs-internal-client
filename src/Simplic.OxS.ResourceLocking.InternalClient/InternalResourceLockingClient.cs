using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.ResourceLocking.InternalClient
{
    public class InternalResourceLockingClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalResourceLockingClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<bool?> CreateLock(Guid resourceId, Guid userId)
        {
            try
            {
                return await Get<bool?>("resourcelocking", "ResourceLocking", "create-lock", new Dictionary<string, string>
                {
                    { "resourceId", resourceId.ToString() },
                    { "userId", userId.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Couldn't make internal auth/user call InternalUserClient.GetUserByEmail", ex);
                throw;
            }
        }

        public async Task RefreshLock(Guid resourceId, Guid userId)
        {
            try
            {
                await Get<bool?>("resourcelocking", "ResourceLocking", "refresh-lock", new Dictionary<string, string>
                {
                    { "resourceId", resourceId.ToString() },
                    { "userId", userId.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Couldn't make internal auth/user call InternalUserClient.GetUserByEmail", ex);
                throw;
            }
        }

        public async Task<bool?> ReleaseLock(Guid resourceId, Guid userId)
        {
            try
            {
                return await Get<bool?>("resourcelocking", "ResourceLocking", "release-lock", new Dictionary<string, string>
                {
                    { "resourceId", resourceId.ToString() },
                    { "userId", userId.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Couldn't make internal auth/user call InternalUserClient.GetUserByEmail", ex);
                throw;
            }
        }

        public async Task<bool?> CheckLocked(Guid resourceId)
        {
            try
            {
                return await Get<bool?>("resourcelocking", "ResourceLocking", "check-lock", new Dictionary<string, string>
                {
                    { "resourceId", resourceId.ToString() }
                });
            }
            catch (Exception ex)
            {
                logger.LogError("Couldn't make internal auth/user call InternalUserClient.GetUserByEmail", ex);
                throw;
            }
        }
    }
}
