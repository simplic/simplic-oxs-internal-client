namespace Simplic.OxS.Reporting.InternalClient.Model;

/// <summary>
/// Request to render a report based on a configured send option and upload the result to the CDN.
/// </summary>
public class RenderAndUploadReportRequest
{
    /// <summary>
    /// Gets or sets the name of the report to render.
    /// </summary>
    public string ReportName { get; set; }

    /// <summary>
    /// Gets or sets the name of the send option that should be used.
    /// </summary>
    public string SendOptionName { get; set; }

    /// <summary>
    /// Gets or sets the parameters that should be passed to the report.
    /// </summary>
    public IList<RenderReportParameter> Parameters { get; set; }
}
