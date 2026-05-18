using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.Accounting.InternalClient;

public class InternalGeneralLedgerAccountGroupClient : InternalClientBase
{
    private readonly ILogger<InternalClientBase> logger;

    public InternalGeneralLedgerAccountGroupClient(
            IOptions<AuthSettings> settings,
            IRequestContext requestContext,
            ILogger<InternalClientBase> logger,
            IConfiguration configuration)
        : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a general ledger account group by id.
    /// </summary>
    /// <param name="id">General ledger account group id</param>
    /// <returns></returns>
    public async Task<GeneralLedgerAccountGroupInternalModel?> GetById(Guid id)
    {
        try
        {
            return await Get<GeneralLedgerAccountGroupInternalModel?>("accounting", "InternalGeneralLedgerAccountGroup", "get-by-id",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Could not make internal general ledger account group call InternalGeneralLedgerAccountGroupClient.GetById", ex);
            throw;
        }
    }
}