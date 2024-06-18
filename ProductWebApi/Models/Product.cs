using System.ComponentModel.DataAnnotations;

namespace ProductWebApi.Models
{
    public class Product
    {
        [Key]
        public int p_id { get; set; }
        public string? p_name { get; set; }
        public string? p_desc{ get; set; }
        public double p_price { get; set; }

    }
}
