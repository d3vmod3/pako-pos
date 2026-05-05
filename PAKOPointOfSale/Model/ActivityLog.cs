using System.ComponentModel.DataAnnotations;
using WinFormsApp1.Model;

public class ActivityLog
{
    public int id { get; set; }
    public DateTime timestamp { get; set; }
    public string user { get; set; }

    public string module { get; set; }
    public string action { get; set; }

    public string? description { get; set; }

    public string? payload { get; set; }
}
