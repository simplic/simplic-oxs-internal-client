using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Accounting.InternalClient;

public class InternalGLAGroupResolutionConfigurationClient : InternalClientBase
{
    private readonly ILogger<InternalClientBase> logger;

    public InternalGLAGroupResolutionConfigurationClient(
            IOptions<AuthSettings> settings,
            IRequestContext requestContext,
            ILogger<InternalClientBase> logger,
            IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a GLA group resolution configuration by id.
    /// </summary>
    /// <param name="id">GLA group resolution configuration id.</param>
    /// <returns></returns>
    public async Task<GLAGroupResolutionConfigurationInternalModel?> GetById(Guid id)
    {
        try
        {
            return await Get<GLAGroupResolutionConfigurationInternalModel?>("accounting", "InternalGLAGroupResolutionConfiguration", "get-by-id",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalGLAGroupResolutionConfigurationClient.GetById", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets all GLA group resolution configurations for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<IEnumerable<GLAGroupResolutionConfigurationInternalModel>?> GetByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<IEnumerable<GLAGroupResolutionConfigurationInternalModel>?>("accounting", "InternalGLAGroupResolutionConfiguration", "get-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalGLAGroupResolutionConfigurationClient.GetByBillingLineContext", ex);
            throw;
        }
    }

    /// <summary>
    /// Gets the active GLA group resolution configuration for a given billing line context.
    /// </summary>
    /// <param name="billingLineContext">Identifier of the billing line context (e.g. tour, shipment).</param>
    /// <returns></returns>
    public async Task<GLAGroupResolutionConfigurationInternalModel?> GetActiveByBillingLineContext(string billingLineContext)
    {
        try
        {
            return await Get<GLAGroupResolutionConfigurationInternalModel?>("accounting", "InternalGLAGroupResolutionConfiguration", "get-active-by-billing-line-context",
                new Dictionary<string, string>
                {
                    { "billingLineContext", billingLineContext }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal accounting call InternalGLAGroupResolutionConfigurationClient.GetActiveByBillingLineContext", ex);
            throw;
        }
    }
}