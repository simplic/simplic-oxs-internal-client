namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a personal account.
    /// </summary>
    public class PersonalAccountInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the sale terms of payment.
        /// </summary>
        public TermsOfPaymentInternalModel? SaleTermsOfPayment { get; set; }

        /// <summary>
        /// Gets or sets the purchase terms of paymnent.
        /// </summary>
        public TermsOfPaymentInternalModel? PurchaseTermsOfPayment { get; set; }

        /// <summary>
        /// Gets or sets the tax group.
        /// </summary>
        public TaxGroupInternalModel? TaxGroup { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// <para>
        /// A personal account can contain multiple addresses.
        /// </para>
        /// </summary>
        public IList<AddressInternalModel> Addresses { get; set; }
            = new List<AddressInternalModel>();

        /// <summary>
        /// gets or sets the number.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the vat id.
        /// </summary>
        public string? VatId { get; set; }

        /// <summary>
        /// Gets or sets the personal account type. (creditor / debitor)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the credit limit.
        /// </summary>
        public CreditLimitInternalModel CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the create date time.
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the update date time.
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the update user id.
        /// </summary>
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the udate user name.
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets whether the personal account is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
