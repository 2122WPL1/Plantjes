using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantjes.Utilities.Attributes
{
    class ClearableAttribute<T> : Attribute
    {
        public T Value { get; set; }

        public ClearableAttribute(T value = default)
        {
            Value = value;
        }
    }
}