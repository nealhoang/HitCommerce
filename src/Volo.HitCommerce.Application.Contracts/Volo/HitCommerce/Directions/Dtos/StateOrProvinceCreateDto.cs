using System;
using System.ComponentModel.DataAnnotations;

namespace Volo.HitCommerce.Directions.Dtos
{
    public class StateOrProvinceCreateDto
    {
        public Guid CountryId { get; set; }

        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }
    }
}