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
    public class TransactionDTO : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Amount { get; set; }

        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public long CustomerId { get; set; }
        public CustomerDTO Customer { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public long BranchId { get; set; }
        public BranchDTO Branch { get; set; }

    }
}
