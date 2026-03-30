using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scot_Water_Application.Models
{
    public class Businesses
    {
        [Key]
        public int BusinessID { get; set; } //Primary Key
        public string BusinessName {  get; set; } //Business Name
        public string BusinessEmail { get; set; } //Business Email
        public string BusinessContactNumber { get; set; } //Business Contact Number
        public string BusinessCity { get; set; } //Location of Business
        public string BusinessPostcode { get; set; } //Business Postcode

        [ForeignKey("Readings")]
        public int MeterID { get; set; }
        public Readings Readings { get; set; }
    }
}
