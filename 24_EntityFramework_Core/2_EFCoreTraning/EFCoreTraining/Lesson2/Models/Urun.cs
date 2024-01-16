using Lesson2.Models.Base;

namespace Lesson2.Models
{
    public class Urun : BaseEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
        public int StokAdedi { get; set; }

        public ICollection<Parca> Parcalar { get; set; }
    }


}
