﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosotronics.Persistence.Models
{
    public class BrandDTO : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [Column(TypeName = "bigint")]
        public long CategoryId { get; set; }

        [Column(TypeName = "bigint")]
        public long SubCategoryId { get; set; }
    }
}
