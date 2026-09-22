using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Accounting.InternalClient;

public class InternalCostCenterResolutionConfigurationClient : InternalClientBase
{
    private readonly ILogger<InternalClientBase> logger;

    public InternalCostCenterResolutionConfigurationClient(
            IOptions<AuthSettings> settings,
            IRequestContext requestContext,
            ILogger<InternalClientBase> logger,
            IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a cost center resolution configuration by id.
    /// </summary>
    /// <param name="id">Cost center resolution configuration id.</param>
    /// <returns></returns>
    public async Task<CostCenterResolutionConfigurationInternalModel?> GetById(Guid id)
    {
        try
        {
            return await Get<CostCenterResolutionConfigurationInternalModel?>("accounting", "InternalCostCenterResolutionConfiguration", "get-by-id",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalBillingLineResolutionConfigurationClient.GetById", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets all cost center resolution configurations for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<IEnumerable<CostCenterResolutionConfigurationInternalModel>?> GetByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<IEnumerable<CostCenterResolutionConfigurationInternalModel>?>("accounting", "InternalCostCenterResolutionConfiguration", "get-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalBillingLineResolutionConfigurationClient.GetByBillingLineContext", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets the active cost center resolution configuration for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<CostCenterResolutionConfigurationInternalModel?> GetActiveByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<CostCenterResolutionConfigurationInternalModel?>("accounting", "InternalCostCenterResolutionConfiguration", "get-active-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalBillingLineResolutionConfigurationClient.GetActiveByBillingLineContext", ex);
            throw;
        }
    }
}