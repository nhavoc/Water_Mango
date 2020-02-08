using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PWM.Models
{
    public class Plant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? LastWatered { get; set; }

        [ScaffoldColumn(false)]
        public bool NeedsWater 
        {
            get
            {
                return LastWatered == null ? true : (DateTime.Now - LastWatered.Value).Hours >= 6;
            }
        }
    }
}