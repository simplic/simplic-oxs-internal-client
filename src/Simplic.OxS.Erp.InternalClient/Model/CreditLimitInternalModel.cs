namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of the credit limit of a personal account.
    /// </summary>
    public class CreditLimitInternalModel
    {
        /// <summary>
        /// Gets the insurance amount.
        /// </summary>
        public double Insurance { get; set; }

        /// <summary>
        /// Gets the creditworthiness of the customer.
        /// </summary>
        public string? Creditworthiness { get; set; }

        /// <summary>
        /// Gets the credit limit.
        /// </summary>
        public string? Limit { get; set; }
    }
}
