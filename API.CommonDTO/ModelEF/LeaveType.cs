using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.CommonDTO.ModelEF
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
