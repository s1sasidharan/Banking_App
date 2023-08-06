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
    public class AttributeDTO : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        [Column(TypeName = "nvarchar(225)")]
        public string Value { get; set; }
    }
}
