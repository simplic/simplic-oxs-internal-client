using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Accounting.InternalClient;

public class InternalCostCenterClient : InternalClientBase
{
    private readonly ILogger<InternalClientBase> logger;

    public InternalCostCenterClient(
            IOptions<AuthSettings> settings,
            IRequestContext requestContext,
            ILogger<InternalClientBase> logger,
            IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a costcenter by id.
    /// </summary>
    /// <param name="id">costcenter id</param>
    /// <returns></returns>
    public async Task<CostCenterInternalModel?> GetById(Guid id)
    {
        try
        {
            return await Get<CostCenterInternalModel?>("accounting", "InternalCostCenter", "get-by-id",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalCostCenterClient.GetById", ex);
            throw;
        }
    }
}