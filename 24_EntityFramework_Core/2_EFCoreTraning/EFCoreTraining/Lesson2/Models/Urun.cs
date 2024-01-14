using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
        public int StokAdedi { get; set; }

        public ICollection<Parca> Parcalar { get; set; }
    }
}
