using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Organization.InternalClient.Model
{
    /// <summary>
    /// Represents a certificate
    /// </summary>
    public class CertificateModel
    {
        /// <summary>
        /// Gets or sets the certiciate id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Contains the certificate file
        /// </summary>
        public byte[] CertFile { get; set; }

        /// <summary>
        /// Gets or sets the certificate issuer
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the certificate subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the from valid date
        /// </summary>
        public DateTime NotBefore { get; set; }

        /// <summary>
        /// Gets or sets the to valid date
        /// </summary>
        public DateTime NotAfter { get; set; }

        /// <summary>
        /// Gets or sets the serial number
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint
        /// </summary>
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the create datetime
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the create userid
        /// </summary>
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create username
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the update datetime
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the update user-id
        /// </summary>
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the update username
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets an optional pfx file
        /// </summary>]
        public byte[]? PfxFile { get; set; }

        /// <summary>
        /// Gets or sets the pfx password
        /// </summary>]
        public string? PfxPassword { get; set; }
    }
}
