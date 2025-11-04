using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int id { get; set; }
    [ForeignKey("userType")]
    public int user_type_id { get; set; }
    [MaxLength(32)]
    public string username { get; set; }
    public string password { get; set; }
    [MaxLength(20)]
    public string first_name { get; set; }
    [MaxLength(20)]
    public string? middle_name { get; set; }
    [MaxLength(20)]
    public string last_name { get; set; }
    public DateTime birthday { get; set; }
    [MaxLength(6)]
    public string gender { get; set; }
    [MaxLength(3)]
    public string? suffix { get; set; }
    public DateTime created_at { get; set; }
    public Boolean is_active { get; set; }
    public Boolean is_reset { get; set; }
    public UserType userType { get; set; }
}
