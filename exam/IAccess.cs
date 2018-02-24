using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public interface IAccess
        {
        int statusAccess { get; set; }
        void TryCheck(Employee p);


    }
    }
