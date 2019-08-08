using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_FrameworkProject.Models {
    public class Student {

        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600, 2400, ErrorMessage = "SAT score 600 <= x <= 2400")]
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        //int? is a new type and it allows an "int" to accept a null value
        public int? MajorId { get; set; }
        //"virtual" keyword, the first Major is the type and the second Major is the variable
        public virtual Major Major { get; set; }

        public override string ToString() {
            return $"Id[{this.Id}], Name[{this.Firstname} {this.Lastname}]...";
        }

        // must have a public default constructor
        public Student() {

        }

    }
}
