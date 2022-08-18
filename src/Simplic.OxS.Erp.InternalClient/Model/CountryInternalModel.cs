namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a transaction country.
    /// </summary>
    public class CountryInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }
    }
}
