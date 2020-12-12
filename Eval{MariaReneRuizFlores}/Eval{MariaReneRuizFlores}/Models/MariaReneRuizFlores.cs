using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eval_MariaReneRuizFlores_.Models
{
public class MyArray
{
        private const object http;

        [Key]
        [Required]
        [StringLength(50,MinimumLength=3)]
    public string name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string capital { get; set; }
        [Required]
        public int population { get; set; }
        [Required]
        public List<double> latlng { get; set; }
        [Required]
        public List<string> timezones { get; set; }
        [Required]
        public List<ConcurrencyCheckAttribute> currencies { get; set; }
        [Required]
        [RegularExpression(^http://[A-Za-z0-9/]+$")]
        public string flag { get; set; }
   
}

}