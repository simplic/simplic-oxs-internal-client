using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Mail.InternalClient;

public class InternalMailClient(
    IOptions<AuthSettings> settings,
    IRequestContext requestContext,
    ILogger<InternalMailClient> logger,
    IConfiguration configuration
) : InternalClientBase(settings, requestContext, logger, configuration)
{
    public async Task<SendMailInternalResponse?> SendMail(SendMailInternalRequest request)
    {
        try
        {
            return await Post<SendMailInternalResponse, SendMailInternalRequest>(
                "mail",
                "InternalMail",
                "send",
                request
            );
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed {ex}", ex);
            throw;
        }
    }
}
