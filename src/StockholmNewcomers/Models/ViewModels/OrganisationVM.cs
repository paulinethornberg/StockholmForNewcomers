﻿using StockholmNewcomers.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockholmNewcomers.Models.ViewModels
{
    public class OrganisationVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Info { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? Type { get; internal set; }
        public byte? Approve { get; set; }

        public int CategoryNumber { get; set; }
         public List<TagsCategory> Categories { get; set; }
        public List<Tags> Tags { get; set; }
    }
}
