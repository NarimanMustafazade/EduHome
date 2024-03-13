using System;
using System.Collections.Generic;

namespace EduHome.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public static implicit operator Course(List<Course> v)
        {
            throw new NotImplementedException();
        }
    }
}
