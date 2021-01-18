using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ISubject
    {
        void Register(IObserver obs);
        void Notify(string data);
        void Changed(string data);
    }
}
