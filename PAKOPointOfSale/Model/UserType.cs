using System;
using WinFormsApp1.Model;

public class UserType
{
    public int id { get; set; }
    public string name { get; set; }

    public ICollection<User> Users { get; set; }
}
