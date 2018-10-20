using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class AbuseReport
    {
        private int ID, recordedBy, studentId, guardianId;
        private string description, actionTaken, comment;
        private DateTime date;

        public AbuseReport(int iD, int recordedBy, int studentId, int guardianId, string description, string actionTaken, string comment, DateTime date)
        {
            ID = iD;
            this.recordedBy = recordedBy;
            this.studentId = studentId;
            this.guardianId = guardianId;
            this.description = description;
            this.actionTaken = actionTaken;
            this.comment = comment;
            this.date = date;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int RecordedBy { get => recordedBy; set => recordedBy = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int GuardianId { get => guardianId; set => guardianId = value; }
        public string Description { get => description; set => description = value; }
        public string ActionTaken { get => actionTaken; set => actionTaken = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}