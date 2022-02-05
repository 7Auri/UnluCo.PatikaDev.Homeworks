using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_patika_dev.Entity
{
    public class Attendance:IEntity
    {
       
        public virtual Student Students { get; set; }
        
        public float AttendanceWeek8 { get; set; }
        public virtual Success Successz { get; set; }

    }
}
