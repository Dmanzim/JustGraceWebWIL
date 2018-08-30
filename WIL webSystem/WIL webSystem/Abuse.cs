using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WIL_webSystem
{
    public class Abuse
    {
        public virtual int studentId
        {
            get;
            set;
        }

        public virtual int guardianId
        {
            get;
            set;
        }

        public virtual string description
        {
            get;
            set;
        }

        public virtual string actionTaken
        {
            get;
            set;
        }

        public virtual string comment
        {
            get;
            set;
        }

        public virtual DateTime dateCreated
        {
            get;
            set;
        }

        public virtual int id
        {
            get;
            set;
        }

        public virtual int staffId
        {
            get;
            set;
        }

        public virtual void recordAbuseReport(int studentId, string comment, string description, int guardianId, int staffId, string actionTaken)
        {
            throw new System.NotImplementedException();
        }

        public virtual Abuse viewAbuseReport(object studentId)
        {
            throw new System.NotImplementedException();
        }
    }
}