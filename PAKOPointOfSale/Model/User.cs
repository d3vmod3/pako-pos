using System;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int id { get; set; }
    [ForeignKey("userType")]
    public int user_type_id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string first_name { get; set; }
    public string? middle_name { get; set; }
    public string last_name { get; set; }
    public DateTime birthday { get; set; }
    public string gender { get; set; }
    public string? suffix { get; set; }
    public DateTime created_at { get; set; }
    public Boolean is_active { get; set; }
    public Boolean is_reset { get; set; }
    public UserType userType { get; set; }
}
