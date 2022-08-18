using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Erp.InternalClient.Model
{
    public class TermsOfPaymentInternalModel
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
        /// Gets or sets the number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cash discount quantity.
        /// </summary>
        public decimal CashDiscount { get; set; }

        /// <summary>
        /// Gets or sets the number of days the cash discount applies for.
        /// </summary>
        public ushort CashDiscountDays { get; set; }

        /// <summary>
        /// Gets or sets the number of days to payment deadline.
        /// </summary>
        public ushort PaymentDeadlineDays { get; set; }

        /// <summary>
        /// Gets or sets the formatted text.
        /// </summary>
        public string? FormattedText { get; set; }

        /// <summary>
        /// Gets or sets wether the terms of paymant are deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
