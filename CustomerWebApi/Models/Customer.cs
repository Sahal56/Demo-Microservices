using System.ComponentModel.DataAnnotations;

namespace CustomerWebApi.Models
{
    public class Customer
    {
        [Key]
        public int c_id { get; set; }
        public string? c_name { get; set; }
        public string? c_city { get; set; }
        public string? c_state { get; set; }
        public string? c_phone_num { get; set; }
        public DateTime? c_dob { get; set; }

    }
}
