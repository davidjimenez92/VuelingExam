using System;
using System.Collections.Generic;

namespace VuelingExam.Domain.Entities
{
	public class Register
    {
		public string Name { get; set; }
		public string Planet { get; set; }
		public DateTime Date { get; set; }

		public override bool Equals(object obj)
		{
			return obj is Register rebeld &&
				   Name == rebeld.Name &&
				   Planet == rebeld.Planet &&
				   Date == rebeld.Date;
		}

		public override int GetHashCode()
		{
			var hashCode = -1069447958;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Planet);
			hashCode = hashCode * -1521134295 + Date.GetHashCode();
			return hashCode;
		}

		public override string ToString()
		{
			return $"Rebeld {Name} on {Planet} at {Date}";
		}
	}
}
