using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServis.Entities.Servis
{
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage ="Adı Soyadı / Ünvan Alanaı Boş Geçilemez")]
        public string AdSoyad { get; set; }//adı soyadı unvanı
        [MaxLength(20)]
        [Required(ErrorMessage ="Telefon Alanını Boş Bırakmayınız.")]
        public string Telefon { get; set; }
        [MaxLength(100)]
        public string Eposta { get; set; }
        [MaxLength(500)]
        public string Adres { get; set; }

        public List<Isemri> Isemris { get; set; }
    }
}
