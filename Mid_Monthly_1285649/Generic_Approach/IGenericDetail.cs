using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public interface IGenericDetail<T>
    {
        string GetDetails<T1>(T1 obj);
    }
}
