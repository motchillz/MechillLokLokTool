﻿using System;
using System.Collections.Generic;

namespace PNB.Domain.Models
{
    public partial class LocalizedProperty
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int LanguageId { get; set; }
        public string LocaleKeyGroup { get; set; }
        public string LocaleKey { get; set; }
        public string LocaleValue { get; set; }
    }
}
