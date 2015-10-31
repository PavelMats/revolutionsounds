using Revolutionsounds.Entities.Abstract;

namespace Revolutionsounds.Entities.Data
{
    public class Story : AuditableEntity<long>
    {
        public string Name { get; set; }

        public string Сontent { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public decimal Count { get; set; }
    }
}
