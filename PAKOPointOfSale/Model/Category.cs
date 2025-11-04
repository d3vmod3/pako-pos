using System.ComponentModel.DataAnnotations;
using WinFormsApp1.Model;

public class Category
{
    public int id { get; set; }
    [MaxLength(50)]
    public string name { get; set; }
    public string? description { get; set; }
}
