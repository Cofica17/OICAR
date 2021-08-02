namespace WebServis.Models.Category
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleModel")]
    public partial class VehicleModel
    {
        [Key]
        public int IDVehicleModel { get; set; }

        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }

        [JsonIgnore]
        public int VehicleManufacturerID { get; set; }
    }
}
