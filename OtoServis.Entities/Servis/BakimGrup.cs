using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServis.Entities.Servis
{
    public class BakimGrup
    {
        [Key]
        public int BakimGrupId { get; set; }
        public string BakimGrupAd { get; set; }

        public List<Bakim> Bakims { get; set; }
    }
}
