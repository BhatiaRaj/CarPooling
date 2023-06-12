using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarPooling.Models
{
    public class Carpooling
    {
        [Key]
        public int Id { get; set; }

        public long PsNo { get; set; }

        public string EmployeeName { get; set; }

       
        public string EmailId { get; set; }

        
        public string Dept { get; set; }

        public string Address { get; set; }

        public long Mobile{ get; set; }

        // Wheeler Type 2 or 4
        public long Wheeler { get; set; }

        // Bording Point
        public string BPoint { get; set; }

        public string Route { get; set; }

        // Leaving Time
        public string LTime { get; set; }

        // Arriving Time
        public string ATime { get; set; }

        //No. of Pessengers can be accommodated
        public long Person { get; set; }

        //Approximate Cost Per Person:
        public long Cost { get; set; }

        //public string CreatedBy { get; set; }


        
    }
}
