﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
	public virtual int studentId
	{
		get;
		set;
	}

	public virtual string name
	{
		get;
		set;
	}

	public virtual string lastName
	{
		get;
		set;
	}

	public virtual int guardianId
	{
		get;
		set;
	}

	public virtual string Password
	{
		get;
		set;
	}

	public virtual bool isActive
	{
		get;
		set;
	}

	public virtual IEnumerable<Abuse> Abuse
	{
		get;
		set;
	}

	public virtual IEnumerable<Attendance> Attendance
	{
		get;
		set;
	}

	public virtual void RegisterNewStudent()
	{
		throw new System.NotImplementedException();
	}

}

