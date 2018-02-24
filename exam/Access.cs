using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Access :  Employee, IAccess
    {
        public int statusAccess { get; set; }

    

        public void TryCheck(Employee p)
        {
            int num = 0;
            do
            {
                
                Console.WriteLine("Enter Password");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != p.pas);

            Console.Clear();
            Console.WriteLine("Password entered successfully");
            
        }
    }
}
