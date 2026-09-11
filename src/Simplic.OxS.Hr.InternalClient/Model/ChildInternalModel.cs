using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Hr.InternalClient.Model;

/// <summary>
/// Represents a child of an employee.
/// </summary>
public class ChildInternalModel
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the child.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets whether the birth certificate has been archived.
    /// </summary>
    public bool BirthCertificateArchived { get; set; }
}