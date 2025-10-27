using System;
using WinFormsApp1.Model;

public class SupplierDetails
{
    public int id { get; set; }
    public string name { get; set; }
    public string? address { get; set; }
    public string? contact_number { get; set; }
    public string? account_number { get; set; }
    public string? gateway { get; set; }
    public DateTime created_at { get; set; }
    public Boolean is_active { get; set; }
}
