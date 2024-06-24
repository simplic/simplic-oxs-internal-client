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
    }
}
