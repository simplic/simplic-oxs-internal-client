using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.Profile.InternalClient.Model;

public class ProfileSettingsModel
{
    public UserProfileModel UserProfile { get; set; }
    public AppSettings AppSettings { get; set; }

    /// <summary>
    /// Gets or sets wherther the user wants to receive newsletter mails.
    /// </summary>
    public bool ReceiveNewsletter { get; set; }

    /// <summary>
    /// Gets or sets a property to indicate whether the user has finished the setup wizard.
    /// </summary>
    public bool? FinishedSetupWizard { get; set; }

    /// <summary>
    /// Get or sets a property to indicate whether the user has finished the tour guide.
    /// </summary>
    public bool? FinishedTourGuide { get; set; }
}

public class UserProfileModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? AboutMe { get; set; }
    public string? Thumbnail { get; set; }
}

public class AppSettings
{
    public GlobalAppSettings Global { get; set; } = new();
}

public class GlobalAppSettings
{
    /// <summary>
    /// Gets or sets the language.<br/>
    /// Common abbreviation such as 'en' or 'de'.<br/>
    /// Defaults to 'de'.
    /// </summary>
    public string Language { get; set; } = "de";
}