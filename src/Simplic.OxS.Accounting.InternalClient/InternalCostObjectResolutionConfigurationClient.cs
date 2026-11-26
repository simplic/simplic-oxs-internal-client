using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Accounting.InternalClient;

public class InternalCostObjectResolutionConfigurationClient : InternalClientBase
{
    private readonly ILogger<InternalClientBase> logger;

    public InternalCostObjectResolutionConfigurationClient(
            IOptions<AuthSettings> settings,
            IRequestContext requestContext,
            ILogger<InternalClientBase> logger,
            IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a cost object resolution configuration by id.
    /// </summary>
    /// <param name="id">Cost object resolution configuration id.</param>
    /// <returns></returns>
    public async Task<CostObjectResolutionConfigurationInternalModel?> GetById(Guid id)
    {
        try
        {
            return await Get<CostObjectResolutionConfigurationInternalModel?>("accounting", "InternalCostObjectResolutionConfiguration", "get-by-id",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalCostObjectResolutionConfigurationClient.GetById", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets all cost object resolution configurations for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<IEnumerable<CostObjectResolutionConfigurationInternalModel>?> GetByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<IEnumerable<CostObjectResolutionConfigurationInternalModel>?>("accounting", "InternalCostObjectResolutionConfiguration", "get-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalCostObjectResolutionConfigurationClient.GetByBillingLineContext", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets the active cost object resolution configuration for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<CostObjectResolutionConfigurationInternalModel?> GetActiveByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<CostObjectResolutionConfigurationInternalModel?>("accounting", "InternalCostObjectResolutionConfiguration", "get-active-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalCostObjectResolutionConfigurationClient.GetActiveByBillingLineContext", ex);
            throw;
        }
    }
}