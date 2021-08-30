using ScheduleCreator.Models;
using ScheduleCreator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCreator
{
    public static class SampleData
    {
        public static void Initialize(ScheduleContext context)
        {
            if (!context.Lessons.Any())
            {
                var schedule = new Schedule
                {
                    Name = "Sample schedule"
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();

                var lessons = new List<Lesson>()
                {
                    new Lesson
                    {
                        Name = "Higher math",
                        Number = LessonsNumbers.First,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Object oriented programming",
                        Number = LessonsNumbers.Second,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Fundamentals of the theory of information systems",
                        Number = LessonsNumbers.Third,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Organization of databases and knowledge",
                        Number = LessonsNumbers.Fourth,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Systems modeling",
                        Number = LessonsNumbers.Fifth,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Professional foreign language",
                        Number = LessonsNumbers.Sixth,
                        Day = Days.Monday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Philosophy of sustainable development",
                        Number = LessonsNumbers.First,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Fundamentals of information systems theory",
                        Number = LessonsNumbers.Second,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Information and computer systems",
                        Number = LessonsNumbers.Third,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Computational methods",
                        Number = LessonsNumbers.Fourth,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.Fifth,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Professional foreign language",
                        Number = LessonsNumbers.Sixth,
                        Day = Days.Tuesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Programming",
                        Number = LessonsNumbers.First,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Philosophy of Sustainable Development",
                        Number = LessonsNumbers.Second,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Fundamentals of the theory of information systems",
                        Number = LessonsNumbers.Third,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.Fourth,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Programming",
                        Number = LessonsNumbers.Fifth,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Computational methods",
                        Number = LessonsNumbers.Sixth,
                        Day = Days.Wednesday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.First,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Programming",
                        Number = LessonsNumbers.Second,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Information and computer systems",
                        Number = LessonsNumbers.Third,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Professional Foreign Language ",
                        Number = LessonsNumbers.Fourth,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.Fifth,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.Sixth,
                        Day = Days.Thursday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Programming",
                        Number = LessonsNumbers.First,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Programming",
                        Number = LessonsNumbers.Second,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Discrete Mathematics",
                        Number = LessonsNumbers.Third,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Organization of databases and knowledge",
                        Number = LessonsNumbers.Fourth,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Professional Foreign Language",
                        Number = LessonsNumbers.Fifth,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },
                    new Lesson
                    {
                        Name = "Systems modeling",
                        Number = LessonsNumbers.Sixth,
                        Day = Days.Friday,
                        ScheduleId = schedule.Id,
                        Schedule = schedule
                    },

                };

                context.Lessons.AddRange(lessons);
                context.SaveChanges();
            }
        }
    }
}
