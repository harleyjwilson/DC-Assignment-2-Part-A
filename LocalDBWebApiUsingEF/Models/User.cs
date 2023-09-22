﻿namespace LocalDBWebApiUsingEF.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }
        //public string? picture { get; set; }
        public string? Password { get; set; }
        // Navigation Property for BankAccounts
        public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    }
}
