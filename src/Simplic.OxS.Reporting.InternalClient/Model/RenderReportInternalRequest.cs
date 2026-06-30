namespace Simplic.OxS.Reporting.InternalClient.Model;

public class RenderReportInternalRequest
{
    public string Name { get; set; }

    public IList<RenderReportParameter> Parameters { get; set; }
}
