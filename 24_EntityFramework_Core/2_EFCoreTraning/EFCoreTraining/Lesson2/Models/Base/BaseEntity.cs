using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreatedTime { get; set; }
    }
}
