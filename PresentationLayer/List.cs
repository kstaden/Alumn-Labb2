using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class List
    {
        private string _value;

        public List(string s)
        {
            _value = s;
        }

        public string Value { get { return _value; } set { _value = value; } }
    }
}
