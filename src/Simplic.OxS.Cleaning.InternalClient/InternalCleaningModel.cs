namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents a cleaning order from the cleaning api.
    /// <para>
    /// Note: the deep billing line graph of the cleaning order is intentionally not
    /// exposed by this internal model.
    /// </para>
    /// </summary>
    public class InternalCleaningModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the cleaning station address.
        /// </summary>
        public InternalAddressModel CleaningStation { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public InternalBillableContactModel Customer { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the cleaning.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the cleaning numbner.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the order date of the cleaning order.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the cleaning resources of the order.
        /// </summary>
        public IList<InternalCleaningOrderResourceModel> Resources { get; set; } = new List<InternalCleaningOrderResourceModel>();

        /// <summary>
        /// Gets or sets the cleaning station contact.
        /// </summary>
        public InternalCleaningOrderContactModel? CleaningStationContact { get; set; }

        /// <summary>
        /// Gets or sets whether the cleaning station is an own or a foreign station.
        /// </summary>
        public InternalStationOwnership StationOwnership { get; set; }

        /// <summary>
        /// Gets or sets the selected cleaning procedure.
        /// </summary>
        public InternalCleaningOrderProcedureModel? CleaningProcedure { get; set; }

        /// <summary>
        /// Gets or sets the selected customer specific cleaning procedure.
        /// </summary>
        public InternalCleaningOrderProcedureModel? CustomerCleaningProcedure { get; set; }

        /// <summary>
        /// Gets or sets the cleaning codes of the order.
        /// </summary>
        public IList<InternalCleaningOrderCodeModel> Codes { get; set; } = new List<InternalCleaningOrderCodeModel>();

        /// <summary>
        /// Gets or sets the previous products per chamber.
        /// </summary>
        public IList<InternalCleaningOrderChamberModel> PreviousProductsPerChamber { get; set; } = new List<InternalCleaningOrderChamberModel>();

        /// <summary>
        /// Gets or sets the status of the cleaning order.
        /// </summary>
        public InternalCleaningOrderStatusModel? Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the cleaning.
        /// </summary>
        public DateTime? CleaningStart { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the cleaning.
        /// </summary>
        public DateTime? CleaningEnd { get; set; }

        /// <summary>
        /// Gets or sets the planned start of the cleaning.
        /// </summary>
        public DateTime? PlannedCleaningStart { get; set; }

        /// <summary>
        /// Gets or sets the planned end of the cleaning.
        /// </summary>
        public DateTime? PlannedCleaningEnd { get; set; }

        /// <summary>
        /// Gets or sets the actual start of the cleaning.
        /// </summary>
        public DateTime? ActualCleaningStart { get; set; }

        /// <summary>
        /// Gets or sets the actual end of the cleaning.
        /// </summary>
        public DateTime? ActualCleaningEnd { get; set; }

        /// <summary>
        /// Gets or sets the effective start of the cleaning (actual ?? planned ?? base).
        /// </summary>
        public DateTime? EffectiveCleaningStart { get; set; }

        /// <summary>
        /// Gets or sets the effective end of the cleaning (actual ?? planned ?? base).
        /// </summary>
        public DateTime? EffectiveCleaningEnd { get; set; }

        /// <summary>
        /// Gets or sets internal notes.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets additional work carried out.
        /// </summary>
        public string? AdditionalWork { get; set; }

        /// <summary>
        /// Gets or sets the creation date time.
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the creating user id.
        /// </summary>
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the update date time.
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the updating user id.
        /// </summary>
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets whether the cleaning order is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}