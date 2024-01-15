using Lesson2.Models.Base;

namespace Lesson2.Models
{
    public class UrunParca : BaseEntity
    {
        public int UrunId { get; set; }
        public int ParcaId { get; set; }
        public Parca Parca { get; set; }
        public Urun Urun { get; set; }
    }
}
