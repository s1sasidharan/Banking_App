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
    public class SubCategoryDTO : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [Column(TypeName = "bigint")]
        public long CategoryId { get; set; }
    }
}
