using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SimpleWS
{
	/// <summary>
	/// Summary description for Service
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class Service : System.Web.Services.WebService
	{
		// VERSION 2.0

		void maMethode33333()
		void WorkingOnMyGreatNewFeatureInBranch_5()
		{
		}

		void maMethode22222222()
		{
			Console.WriteLine("toto");
		}
		void maMethode()
		{
			Console.WriteLine("toto");
		}
		void MethodAddedInMaster()
		{
			Console.WriteLine("MethodAddedInMaster");
		}

		void anothermethod()
		{
		}

//modif in feature/branch-2
		[WebMethod]
		// V5
		// V4 start
		public int BookYear(Book book)
		{
			if (null != book)
			{
				var b = (from data in Book.MockData
						 where data.Name.Equals(book.Name, StringComparison.InvariantCultureIgnoreCase)
						 select data).FirstOrDefault();
				if (null != b)
					return b.Year;
			}
			return -1;
		}
	}
}
