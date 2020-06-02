using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.CommonDTO.ModelEF
{
    public class UserRegistration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string EmpName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Password { get; set; }     
        public DateTime DateCreated { get; set; }
    }
}
