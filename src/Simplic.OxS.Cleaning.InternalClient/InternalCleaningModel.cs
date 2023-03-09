namespace Simplic.OxS.Cleaning.InternalClient
{
    public class InternalCleaningModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the cleaning station.
        /// </summary>
        public InternalAddressModel CleaningStation { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public InternalBillableContactModel Customer { get; set; }

        /// <summary>
        /// Gets or sets the cleaning numbner.
        /// </summary>
        public string Number { get; set; }
    }
}