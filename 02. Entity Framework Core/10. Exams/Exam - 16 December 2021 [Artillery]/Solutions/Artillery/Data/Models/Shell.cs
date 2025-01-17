﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Artillery.Data.Models
{
    public class Shell
    {
        public Shell()
        {
            this.Guns = new HashSet<Gun>();
        }

        public int Id { get; set; }

        public double ShellWeight { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string Caliber { get; set; }

        public ICollection<Gun> Guns { get; set; }
    }
}