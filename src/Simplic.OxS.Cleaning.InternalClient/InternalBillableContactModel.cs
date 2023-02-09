namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents a billable contact with an address, a personal account id and an account number.
    /// </summary>
    public class InternalBillableContactModel
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public InternalAddressModel Address { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the personal account id.
        /// <para>
        /// Represents the id of a personal account from the Simplic.ApplicationCollection project.
        /// </para>
        /// </summary>
        public Guid? PersonalAccountId { get; set; }
    }
}
