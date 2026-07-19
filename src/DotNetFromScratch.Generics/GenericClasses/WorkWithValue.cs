using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFromScratch.Generics.GenericClasses
{
    public class WorkWithValue<TValue>
    {
        TValue _value;
        public void GetValue(TValue value)
        {
            _value = value;
        }

        public TValue ReturnValue()
        {
            return _value;
        }
    }
}
