using PAKOPointOfSale.Model;
using System;
using System.ComponentModel.DataAnnotations;
using WinFormsApp1.Model;

public class UserType
{
    public int id { get; set; }
    [MaxLength(10)]
    public string name { get; set; }

    public ICollection<User> Users { get; set; }
    public ICollection<Permission> Permissions { get; set; }

}
