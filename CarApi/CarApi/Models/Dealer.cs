using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class Dealer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public string Contact { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public bool IsActive { get; set; }
    }
}
