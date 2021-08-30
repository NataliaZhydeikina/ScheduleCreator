using ScheduleCreator.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleCreator.Models
{
    public class Lesson
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Schedule")]
        public Guid ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
        public LessonsNumbers Number { get; set; }
        public Days Day { get; set; }
        public string Name { get; set; }

    }
}
