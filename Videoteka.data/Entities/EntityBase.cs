using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka.Data.Entities
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
