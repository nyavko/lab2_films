﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using films.Models;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class FilmArtist
    {
        public int Id { get; set; }
        [Display(Name = "Фільм")]
        public int FilmId { get; set; }
        public int ArtistId { get; set; }
        [Display(Name = "Опис ролі")]
        public string Description { get; set; }

        public virtual Artist Artist { get; set; }
        [Display(Name = "Фільм")]
        public virtual Film Film { get; set; }
    }
}
