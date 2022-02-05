using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_patika_dev.Entity
{
    public class Success:IEntity
    {
       
        public float SuccessStatus { get; set; }
       
        public virtual Student Students { get; set; }

    }
}
