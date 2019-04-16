using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vulnerabilities.Services.Models.MPCconfigModels
{
   public class VServersListingModelMpcConfig
    {
        public int Id { get; set; }

        public string Ip{ get; set; }

        [Required]
        [MaxLength(50)]
        public string SystemName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SystemStatus { get; set; }

        [Required]
        [MaxLength(50)]
        public string SystemType { get; set; }

        [MaxLength(70)]
        public string OSversion { get; set; }


        [MaxLength(50)]
        public string TechnicalOwner { get; set; }

        [MaxLength(70)]
        public string DowntimeContact { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastDetected { get; set; }

        [DisplayFormat(NullDisplayText = "No port")]
        public string Port { get; set; }

        [DisplayFormat(NullDisplayText = "Empty")]
        public string Notes { get; set; }

        public int? VulnerabilityID { get; set; }

        public string Severity { get; set; }
    }
}
