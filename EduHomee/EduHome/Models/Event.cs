using System;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
