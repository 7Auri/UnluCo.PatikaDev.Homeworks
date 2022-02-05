using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_patika_dev.Entity
{

    public class Education:IEntity
    {
        

        public string EducationName { get; set; }
        [Required]
        public ICollection<Teacher> Teachers { get; set; }
        [Required]
        public ICollection<Assistant> Assistants { get; set; }
        [Required]
        public ICollection<Partipant> Partipants { get; set; }
        [Required]
        public ICollection<Student> Students { get; set; }


    }
}
