using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OtoServis.Entities.Web
{
    public class Haritaletisim
    {
        [Key]
        public int HaritaIletisimId { get; set; }
        public string Harita { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Iletisim { get; set; }
        public string Unvan { get; set; }
    }
}
