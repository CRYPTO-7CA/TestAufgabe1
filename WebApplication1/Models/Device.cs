using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Device
    {
        [Key]
        public int _id { get; set; }
        [Required]
        public string id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string deviceTypeId { get; set; }
        [Required]
        public bool failsafe { get; set; }
        public int tempMin { get; set; }
        public int tempMax { get; set; }
        public string installationPosition { get; set; }
        public bool insertInto19InchCabinet { get; set; }
        public bool motionEnable { get; set; }
        public bool siplusCatalog { get; set; }
        public bool simaticCatalog { get; set; }
        public int rotationAxisNumber { get; set; }
        public int positionAxisNumber { get; set; }
        public bool? terminalElement { get; set; }
        public bool? advancedEnvironmentConditions { get; set; }
    }
}
