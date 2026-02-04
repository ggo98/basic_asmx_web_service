using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Book svc = new ServiceReference1.Book();
            //BookYearRequest req = new BookYearRequest() { Body = new BookYearRequestBody() { book = new Book(

            ServiceSoapClient clt = new ServiceSoapClient();
            Book b = new Book() { Name = "test 4" };
            var year = clt.BookYear(b);

            //svc.BookYear(
            //Client.ServiceReference1 service = new 
        }
    }
}
