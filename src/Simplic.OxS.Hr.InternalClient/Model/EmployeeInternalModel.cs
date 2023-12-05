namespace Simplic.OxS.Hr.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a employee.
    /// </summary>
    public class EmployeeInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public AddressInternalModel? Address { get; set; }

        /// <summary>
        /// Gets or sets the PlaceOfBirth.
        /// </summary>
        public string? PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Religion.
        /// </summary>
        public string? Religion { get; set; }

        /// <summary>
        /// Gets or sets the amount of Children.
        /// </summary>
        public double? Children { get; set; }

        /// <summary>
        /// Gets or sets the Citizenship.
        /// </summary>
        public string? Citizenship { get; set; }

        /// <summary>
        /// Gets or sets whether SeverelyDisabled or not.
        /// </summary>
        public bool SeverelyDisabled { get; set; }

        /// <summary>
        /// Gets or set the DisabilityLevel.
        /// </summary>
        public int? DisabilityLevel { get; set; }

        /// <summary>
        /// Gets or sets the TaxOffice.
        /// </summary>
        public string? TaxOffice { get; set; }

        /// <summary>
        /// Gets or sets the SocialSecurtiyNumber.
        /// </summary>
        public string? SocialSecurityNumber { get; set; }

        /// <summary>
        /// Gets or sets the HealthInsurance.
        /// </summary>
        public string? HealthInsurance { get; set; }

        /// <summary>
        /// Gets or sets the IdentitycardNumber
        /// </summary>
        public string? IdentityCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the TaxIdentificationNumber.
        /// </summary>
        public string? TaxIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets the HealthInsuranceNumber.
        /// </summary>
        public string? HealthInsuranceNumber { get; set; }

        /// <summary>
        /// Gets or sets the HandicappedIdNumber.
        /// </summary>
        public string? HandicappedIdNumber { get; set; }

        /// <summary>
        /// Gets or sets the IssuingAuthority.
        /// </summary>
        public string? IssuingAuthority { get; set; }

        /// <summary>
        /// Gets or sets ValidUntil.
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Gets or sets Employment.
        /// </summary>
        public EmploymentInternalModel? Employment { get; set; }

        /// <summary>
        /// Gets or sets the functions of the current employee
        /// </summary>
        public IList<string> Functions { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the employee matchcode
        /// </summary>
        public string? MatchCode { get; set; }

        /// <summary>
        /// Gets or sets whether the employee is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

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
        /// Gets or sets the update user name.
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets the organization id for the contact.
        /// </summary>
        public Guid OrganizationId { get; set; }
    }
}
