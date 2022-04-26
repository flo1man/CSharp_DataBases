﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto
{
    [XmlType("Country")]
    public class ImportCountryModel
    {
        [XmlElement("CountryName")]
        [MinLength(4)]
        [MaxLength(60)]
        public string CountryName { get; set; }

        [XmlElement("ArmySize")]
        [Range(50_000, 10_000_000)]
        public int ArmySize { get; set; }
    }
}
