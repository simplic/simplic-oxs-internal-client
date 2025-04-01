using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.Vehicle.InternalClient.Model;

namespace Simplic.OxS.Vehicle.InternalClient;

public class InternalVehicleClient : InternalClientBase
{
    private readonly ILogger logger;

    public InternalVehicleClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets the api version.
    /// </summary>
    public string ApiVersion => "v2";

    /// <summary>
    /// Gets a vehicle by id.
    /// </summary>
    /// <param name="id">Vehicle id</param>
    /// <returns></returns>
    public async Task<VehicleInternalModel?> Get(Guid id)
    {
        try
        {
            return await Get<VehicleInternalModel?>("vehicle", "InternalVehicle", "",
                new Dictionary<string, string>
                {
                        { "id", id.ToString() }
                });
        }
        catch (Exception ex)
        {
            logger.LogError("Internal call failed", ex);
            throw;
        }
    }
}