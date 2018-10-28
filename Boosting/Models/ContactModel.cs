﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boosting.Models
{
    public class ContactModel
    {
        [Required, Display(Name = "Your name")]
        public string name { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string emailAddress { get; set; }
        public int orderNumber { get; set; }
        [Required]
        public string message { get; set; }
    }
}