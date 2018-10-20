using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Lesson
    {
        private int ID, staffId;
        private string description;
        private DateTime lessonDate;
        private double durationInHours;

        public Lesson(int iD, int staffId, string description, DateTime lessonDate, double durationInHours)
        {
            ID = iD;
            this.staffId = staffId;
            this.description = description;
            this.lessonDate = lessonDate;
            this.durationInHours = durationInHours;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int StaffId { get => staffId; set => staffId = value; }
        public string Description { get => description; set => description = value; }
        public DateTime LessonDate { get => lessonDate; set => lessonDate = value; }
        public double DurationInHours { get => durationInHours; set => durationInHours = value; }
    }
}