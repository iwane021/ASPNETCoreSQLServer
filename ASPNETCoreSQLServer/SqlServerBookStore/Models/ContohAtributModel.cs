﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SqlServerBookStore.Models
{
    public class ContohAtributModel
    {
        [Display(Name = "Contoh Email")]
        [EmailAddressAttribute]
        public String ContohEmail { set; get; }

        [Display(Name = "Contoh URL")]
        [UrlAttribute]
        public String ContohUrl { set; get; }

        [Display(Name = "Contoh Phone")]
        [PhoneAttribute]
        public String ContohPhone { set; get; }

        [Display(Name = "Contoh Password")]
        [DataType(DataType.Password)]
        public String ContohPassword { set; get; }

        [Display(Name = "Contoh Date")]
        [DataType(DataType.Date)]
        public DateTime ContohDate { set; get; }

        [Display(Name = "Contoh Time")]
        [DataType(DataType.Time)]
        public DateTime ContohTime { set; get; }

    }
}
