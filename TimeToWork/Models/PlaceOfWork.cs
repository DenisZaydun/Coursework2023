using System.ComponentModel.DataAnnotations;

namespace TimeToWork.Models
{
    public class PlaceOfWork
    {
        [Key]
        public int ServiceProviderID { get; set; }
        [StringLength(50)]
        public string Location { get; set; }

        public ServiceProvider ServiceProvider { get; set; }
    }
}
