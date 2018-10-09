using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Staff : Employee
{
	public virtual Double salary
	{
		get;
		set;
	}

	public virtual DateTime contractStartDate
	{
		get;
		set;
	}

	public virtual void registerStaff(string firstName, string lastName, string nationalId, string username, string password, bool isActive, string emailAddress, string contactNumber, double salary, object Parameter1)
	{
		throw new System.NotImplementedException();
	}

	public virtual void disableStaff(int educatorId)
	{
		throw new System.NotImplementedException();
	}

}

