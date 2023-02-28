﻿using System.ComponentModel.DataAnnotations;

namespace VehicleManager.Models
{
    public class VehicleCategory
    {
        public int VehicleCategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        [MaxLength(120)]
        public string Description { get; set; } = string.Empty;
        public double PricePerDay { get; set; }
        virtual public List<Car>? Cars { get; set; }
    }
}
