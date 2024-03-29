﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OtoServis.Entities.Web
{
    public class Blog
    {
        public int BlogId { get; set; }
        [MaxLength]
        public string Baslik { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}
