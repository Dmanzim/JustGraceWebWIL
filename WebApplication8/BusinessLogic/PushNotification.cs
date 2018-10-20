using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class PushNotification
    {
        private int ID, staffID;
        private string description, message;
        private bool sent, isStaff, isForStudent, isForGuardian;
        private DateTime date;

        public PushNotification(int iD, int staffID, string description, string message, bool sent, bool isStaff, bool isForStudent, bool isForGuardian, DateTime date)
        {
            ID = iD;
            this.staffID = staffID;
            this.description = description;
            this.message = message;
            this.sent = sent;
            this.isStaff = isStaff;
            this.isForStudent = isForStudent;
            this.isForGuardian = isForGuardian;
            this.date = date;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int StaffID { get => staffID; set => staffID = value; }
        public string Description { get => description; set => description = value; }
        public string Message { get => message; set => message = value; }
        public bool Sent { get => sent; set => sent = value; }
        public bool IsStaff { get => isStaff; set => isStaff = value; }
        public bool IsForStudent { get => isForStudent; set => isForStudent = value; }
        public bool IsForGuardian { get => isForGuardian; set => isForGuardian = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}