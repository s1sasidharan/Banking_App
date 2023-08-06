using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosotronics.Persistence.Models
{
    public class UserDTO:AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string FName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string LName { get; set; }

        [Required]
        [MaxLength(225)]
        [Column(TypeName = "nvarchar(225)")]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MobileNo { get; set; }
    }
}
