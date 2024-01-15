using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;

namespace Simplic.OxS.CDN.InternalClient;

public class InternalCDNClient : InternalClientBase
{
    private readonly ILogger logger;

    public InternalCDNClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets a vehicle by id.
    /// </summary>
    /// <param name="id">Vehicle id</param>
    /// <returns></returns>
    public async Task<UploadInternalResponse?> UploadBytes(UploadBytesInternalRequest request)
    {
        try
        {
            return await Post<UploadInternalResponse, UploadBytesInternalRequest>("cdn", "InternalCDN", "upload", request);
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed", ex);
            throw;
        }
    }
}