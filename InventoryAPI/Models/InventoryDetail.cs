using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Models
{
    public class InventoryDetail
    {

        [Key]
        public int InventoryDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string SKU { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string Quantity { get; set; }
    }
}
