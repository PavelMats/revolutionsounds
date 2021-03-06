﻿using Revolutionsounds.Entities.Abstract;

namespace Revolutionsounds.Entities.Data
{
    public class Story : AuditableEntity<long>
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
