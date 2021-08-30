using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScheduleCreator.Models
{
    public class Schedule
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
