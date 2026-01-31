namespace Simplic.OxS.Organization.InternalClient.Model
{
    /// <summary>
    /// Represents an organization
    /// </summary>
    public class OrganizationModel
    {
        /// <summary>
        /// Gets or sets the organization id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the main-address of the organization
        /// </summary>
        public AddressInternalModel Address { get; set; }

        /// <summary>
        /// Gets or sets the billing-address of organization
        /// </summary>
        public BillingAddressModel BillingAddressModel { get; set; }

        /// <summary>
        /// Gets or set the entra tenant id
        /// </summary>
        public string? EntraTenantId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether admin consent has been granted for the application in Azure Active
        /// Directory.
        /// </summary>
        /// <remarks>This property reflects the admin consent status, which is essential for determining
        /// if the application can access certain resources on behalf of users.</remarks>
        public bool EntraIdAdminConsent { get; set; }
    }
}
