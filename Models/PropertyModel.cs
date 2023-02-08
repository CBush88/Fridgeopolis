﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fridgeopolis.Models
{

    public partial class PropertyModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; } = null!;

        public string SourceUrl { get; set; }

    }
}
