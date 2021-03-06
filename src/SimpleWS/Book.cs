﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWS
{
	public class Book
	{
		private static Book[] _mockData =
		{
			new Book() { Name = "test 1", Year = 2011 },
			new Book() { Name = "test 2", Year = 2012 },
			new Book() { Name = "test 3", Year = 2013 },
		};

		public static Book[] MockData 
		{ 
			get { return _mockData; }
		}

		public string Name { get; set; }
		public int Year { get; set; }

		public override string ToString()
		{
			return Name ?? string.Empty + ", " + Year.ToString();
		}
	}
}