using System.ComponentModel.DataAnnotations;
using WinFormsApp1.Model;

public class Option
{
    public int id { get; set; }
    [Required]
    public string key { get; set; }
    [Required]
    public string value { get; set; }
    public DateTime updated_at { get; set; }
}