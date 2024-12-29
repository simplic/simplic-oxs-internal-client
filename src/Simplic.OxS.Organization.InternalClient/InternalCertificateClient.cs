using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Simplic.OxS.InternalClient;
using Simplic.OxS.Settings;
using Simplic.OxS.Organization.InternalClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Organization.InternalClient
{
    public class InternalCertificateClient : InternalClientBase
    {
        private readonly ILogger<InternalClientBase> logger;

        public InternalCertificateClient(IOptions<AuthSettings> settings, IRequestContext requestContext, ILogger<InternalClientBase> logger, IConfiguration configuration) : base(settings, requestContext, logger, configuration)
        {
            this.logger = logger;
        }

        public async Task<CertificateModel?> GetByGuid(Guid id)
        {
            try
            {
                return await Get<CertificateModel?>("organization", "InternalCertificate", $"{id}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Could make internal certificate call InternalCertificateClient.Get/{id}", ex);
                return null;
                
            }
        }
    }
}
