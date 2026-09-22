using System;
using System.Collections.Generic;

namespace Simplic.OxS.Reporting.InternalClient.Model;

/// <summary>
/// Represents a rendered report document.
/// </summary>
public class ReportDocumentModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public byte[] Bytes { get; set; }
    public IList<ReportParameterModel> Parameters { get; set; }
    public DateTime CreateDateTime { get; set; }
    public Guid? CreateUserId { get; set; }
    public string CreateUserName { get; set; }
    public DateTime UpdateDateTime { get; set; }
    public Guid? UpdateUserId { get; set; }
    public string UpdateUserName { get; set; }
}