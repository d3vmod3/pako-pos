using System.ComponentModel.DataAnnotations;
using WinFormsApp1.Model;

public class Options
{
    public int id { get; set; }
    [MaxLength(50)]
    public string key { get; set; }
    public string? value { get; set; }
}