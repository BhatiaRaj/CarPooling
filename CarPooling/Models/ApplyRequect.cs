using System.ComponentModel.DataAnnotations;

namespace CarPooling.Models
{
    public class carpooling
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public long PsNo { get; set; }

        public string PickUpPoint { get; set; }

        public long Mobile { get; set; }

        public string Time { get; set; }
    }
}
