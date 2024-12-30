using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Approach
{
    public class GenericDetailImpl<T> : IGenericDetail<T>
    {
        public string GetDetails<T1>(T1 obj)
        {
            if (obj is Vehicle)
            {
                Vehicle v = obj as Vehicle;
                return v.Details();
            }
            else
            {
                return "Not a Vehicle!!";
            }
        }
    }
}
