using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lesson
{
	public virtual int id
	{
		get;
		set;
	}

	public virtual DateTime dateTime
	{
		get;
		set;
	}

	public virtual string description
	{
		get;
		set;
	}

	public virtual Double durationOfClass
	{
		get;
		set;
	}

	public virtual int staffId
	{
		get;
		set;
	}

	public virtual void createlesson(Double durationOfClass, string description, DateTime date, int staffId)
	{
		throw new System.NotImplementedException();
	}

}

