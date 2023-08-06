using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using Default=System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosotronics.Persistence.Models
{
    public class AuditableEntity
    {
            [Required]
            [Column(TypeName = "bigint")]
            public long CreatedBy { get; set; }

            [Required]
            [Column(TypeName = "datetime")]
            public DateTime CreatedDate { get; set; }

            [Column(TypeName = "bigint")]
            public long? ModifiedBy { get; set; }

            [Column(TypeName = "datetime")]
            public DateTime? ModifiedDate { get; set; }

            [Required]
            [Default.DefaultValue(true)]
            [Column(TypeName = "bit")]
            public bool IsActive { get; set; }

            [Required]
            [Default.DefaultValue(false)]
            [Column(TypeName = "bit")]
            public bool IsDeleted { get; set; }
        
    }
}
