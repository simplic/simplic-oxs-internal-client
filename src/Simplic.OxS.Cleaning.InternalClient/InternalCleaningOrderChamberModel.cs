namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents the previous products of a single chamber of a cleaning order.
    /// </summary>
    public class InternalCleaningOrderChamberModel
    {
        /// <summary>
        /// Gets or sets the id of the entry.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number of the chamber.
        /// </summary>
        public int ChamberNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the chamber.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the previous products of this chamber as free text.
        /// </summary>
        public IList<string> PreviousProducts { get; set; } = new List<string>();
    }
}
