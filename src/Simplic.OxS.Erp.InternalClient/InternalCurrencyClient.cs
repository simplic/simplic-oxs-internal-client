using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.Erp.InternalClient.Model;

namespace Simplic.OxS.Erp.InternalClient;

/// <summary>
/// Client for accessing currency data internally
/// </summary>
public class InternalCurrencyClient : InternalClientBase
{
    private readonly ILogger logger;

    /// <summary>
    /// Initialize internal currency client
    /// </summary>
    /// <param name="settings">Auth settings</param>
    /// <param name="requestContext">Request context instance</param>
    /// <param name="logger">Logger instance</param>
    /// <param name="configuration">Configuration instance</param>
    public InternalCurrencyClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets the api version
    /// </summary>
    public override string ApiVersion => "v1";

    /// <summary>
    /// Gets a currency by id
    /// </summary>
    /// <param name="id">Currency id</param>
    /// <returns>Currency if found</returns>
    public async Task<CurrencyInternalModel?> Get(Guid id)
    {
        try
        {
            return await Get<CurrencyInternalModel?>("erp", "InternalCurrency", "get-by-id",
                    new Dictionary<string, string>
                    {
                        { "id", $"{id}" }
                    });
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Internal call failed");
            throw;
        }
    }
}