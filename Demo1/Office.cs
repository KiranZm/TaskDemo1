using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
   public class Office : ILogs
    {
        public void login()
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
           
            Console.WriteLine("Hello Dear demo");
            Console.ReadLine();
        }
        public static void main(string[] args)
        {
            Office obj = new Office();
            obj.logout();
        }
       
    }
}
