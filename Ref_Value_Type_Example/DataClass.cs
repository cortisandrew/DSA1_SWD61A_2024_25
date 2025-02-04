using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Value_Type_Example
{
    public class DataClass
    {
        public int DataValue { get; set; } = 0;

        public DataClass() { }

        public DataClass(int dataValue)
        {
            DataValue = dataValue;
        }
    }
}
