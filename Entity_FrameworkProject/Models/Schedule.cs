﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_FrameworkProject.Models {

    public class Schedule {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public Schedule() {

        }
    }
}
