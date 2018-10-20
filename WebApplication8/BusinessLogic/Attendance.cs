using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Attendance
    {
        private int ID, lessonId, studentId, guardianId;
        private DateTime dateRecorded;
        bool didAttend;

        public Attendance(int iD, int lessonId, int studentId, int guardianId, DateTime dateRecorded, bool didAttend)
        {
            ID = iD;
            this.lessonId = lessonId;
            this.studentId = studentId;
            this.guardianId = guardianId;
            this.dateRecorded = dateRecorded;
            this.didAttend = didAttend;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int LessonId { get => lessonId; set => lessonId = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int GuardianId { get => guardianId; set => guardianId = value; }
        public DateTime DateRecorded { get => dateRecorded; set => dateRecorded = value; }
        public bool DidAttend { get => didAttend; set => didAttend = value; }
    }
}