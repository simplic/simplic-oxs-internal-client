using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Identity.InternalClient;

/// <summary>
/// Client to communicate with the internal identity api.
/// </summary>
public class InternalApiKeyClient(
    IOptions<AuthSettings> settings,
    IRequestContext requestContext,
    ILogger<InternalClientBase> logger,
    IConfiguration configuration) :
    InternalClientBase(settings, requestContext, logger, configuration)
{
    private readonly ILogger<InternalClientBase> logger = logger;

    /// <summary>
    /// Validates an api key.
    /// </summary>
    /// <param name="apiKey">The api key.</param>
    /// <returns>A validation result.</returns>
    public async Task<ValidateApiKeyResponse?> ValidateKey(string apiKey)
    {
        try
        {
            return await Get<ValidateApiKeyResponse?>("identity", "InternalApiKey", $"validate-key/{apiKey}");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Could make internal identity call InternalApiKeyClient.ValidateKey");
            return null;
        }
    }
}
