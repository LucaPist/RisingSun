using System.ComponentModel.DataAnnotations;

namespace WebAPI_Sample2.Models
{
    public class UserInfo
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        [Required]
        public string? DisplayName { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [EmailAddress]
        public string? Email2 { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Cognome { get; set; }
        [Required]
        public DateTime? DataNasc { get; set; }
        [Required]
        public string? Indirizzo { get; set; }
        [Required]
        public string? CAP { get; set; }
        [Required]
        public string? Telfono1 { get; set; }
        
        public string? Telfono2 { get; set; }
        [Required]

        public Boolean? Conf { get; set; }    //conf privacy//

        
        public DateTime? CreatedDate { get; set; }
    }
}
