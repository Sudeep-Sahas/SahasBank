using System.ComponentModel.DataAnnotations;

namespace SahasBanking.Models.Account
{
    public class Accounts
    {
        [Key]
        public int Id { get; set; }
        
        public string AccountBalance { get; set; }
    }
}
