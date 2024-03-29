﻿using System;
using System.Collections.Generic;

namespace PNB.Domain.Models
{
    public partial class Calendar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsUser { get; set; }
    }
}
