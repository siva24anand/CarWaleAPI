using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Type { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public string LaunchDate { get; set; }
        public string EstimatedPrice { get; set; }
        public double? StartingPrice { get; set; }
        public string ImageURL { get; set; }
        public bool IsLaunched { get; set; }
        public bool IsUpcoming { get; set; }
        public bool IsPopular { get; set; }

    }
}
