using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Attendance
{
	public virtual int id
	{
		get;
		set;
	}

	public virtual int lessonId
	{
		get;
		set;
	}

	public virtual int studentId
	{
		get;
		set;
	}

	public virtual DateTime dateRecorded
	{
		get;
		set;
	}

	public virtual int guardianId
	{
		get;
		set;
	}

	public virtual bool didAttended
	{
		get;
		set;
	}

	public virtual void recordAttendance(int lessonId, int studentId, int guardianId, bool didAttend)
	{
		throw new System.NotImplementedException();
	}

}

