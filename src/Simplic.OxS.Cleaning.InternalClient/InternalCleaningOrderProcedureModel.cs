namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents the cleaning procedure reference of a cleaning order.
    /// </summary>
    public class InternalCleaningOrderProcedureModel
    {
        /// <summary>
        /// Gets or sets the id of the cleaning procedure.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number of the cleaning procedure.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the name of the cleaning procedure.
        /// </summary>
        public string? Name { get; set; }
    }
}
