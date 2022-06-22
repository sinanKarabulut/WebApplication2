using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table(name:"denemeSinan",Schema = "deneme_schema2")]
    public class Deneme
    {
        public int DenemeId { get; set; }

        public String Adi { get; set; }

    }
}
