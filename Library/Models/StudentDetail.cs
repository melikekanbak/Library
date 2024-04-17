﻿using System;

namespace Library.Models
{
    public class StudentDetail:BaseEntity
    {
        public string SchoolNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int StudentID { get; set; }

        public virtual Student Student { get; set;}
    }
}
