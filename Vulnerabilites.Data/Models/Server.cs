using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vulnerabilities.Data.Models
{
    public class Server
    {
        public Server()
        {
            this.Vulnerabilities = new List<ServerVulnerability>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order =0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Server IP is required")]
        [MaxLength(50)]
        [Column("IP", Order = 1)]
        public string Ip { get; set; }

        [Required(ErrorMessage = "Server name is required")]
        [MaxLength(100)]
        [Column("System name", Order = 2)]
        public string SystemName { get; set; }

        [Required(ErrorMessage = "Server status is required")]
        [MaxLength(50)]
        [Column("System status", Order = 3)]
        public string SystemStatus { get; set; }

        [Required(ErrorMessage = "System type is required")]
        [MaxLength(50)]
        [Column("System type", Order = 4)]
        public string SystemType { get; set; }


        [MaxLength(70)]
        [Column("OS Version", Order = 5)]
        public string OSversion { get; set; }

        [MaxLength(50)]
        [Column("Technical owner", Order = 6)]
        public string TechnicalOwner { get; set; }

        [MaxLength(70)]
        [Column("Downtime contact", Order = 7)]
        public string DowntimeContact { get; set; }

        [Required(ErrorMessage = "Server last detected date is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Last detected date",Order = 8)]
        public DateTime LastDetected { get; set; }

        [DisplayFormat(NullDisplayText = "No port")]
        [Column("Port", Order = 9)]
        public string Port { get; set; }

        [DisplayFormat(NullDisplayText = "Empty")]
        public string Notes { get; set; }

        public List<ServerVulnerability> Vulnerabilities { get; set; }

    }
}
