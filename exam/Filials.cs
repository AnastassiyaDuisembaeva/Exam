using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    [Serializable]
    public class Filials
    {
        public int IDFilials { get; set; }
        public string NameFilials { get; set; }
        public Filials()
        {

        }
        public Filials(int idFilials, string nameFilials)
        {
            IDFilials = idFilials;
            NameFilials = nameFilials;

        }
    }
}
