using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_FrameworkProject.Models {

    public class Course {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Instructor { get; set; }
        public int Credit { get; set; }
        public int MajorId { get; set; }

        public virtual Major Major { get; set; }

        public Course() {

        }
    }
}
