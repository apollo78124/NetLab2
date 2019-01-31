using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_v3.Models
{
    public class Province
    {
        [Key]
        [MaxLength(30)]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
