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
        void testSTASH()
        {
            int aaaa = 123;
            int bb= 123;
        }

        void FEAT1()
        {
            testSTASH();
            Console.WriteLine("FEAT1");
        }

        void FEAT2()
        {
            Console.WriteLine("FEAT2");
        }

        void FEAT3()
        {
            Console.WriteLine("FEAT3");
        }

        [WebMethod]
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

        void BUGFIX1()
        {
            Console.WriteLine("BUGFIX1");
        }

        void BUGFIX2()
        {
            Console.WriteLine("BUGFIX2");
        }

        void BUGFIX3()
        {
            Console.WriteLine("BUGFIX3");
        }
    }
}
