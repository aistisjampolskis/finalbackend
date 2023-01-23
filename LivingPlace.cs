using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsAPI.Models
{
    public class LivingPlace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }

    }

}

