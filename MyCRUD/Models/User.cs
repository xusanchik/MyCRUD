﻿namespace MyCRUD.Models.cs;
public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public List<Product> products { get; set; }
}
