using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;

namespace PresentationLayer.Observer
{
    public class Subject : ISubject
    {
        IList<IObserver> observerr;
        public Subject()
        {
            observerr = new List<IObserver>();

        }
        public void Register(IObserver obs)
        {
            observerr.Add(obs);
        }
        public void Notify(string data)
        {
            foreach (IObserver observers in observerr)
            {
                observers.Update(data);
            }
        }
        public void Changed(string data)
        {
            foreach (var item in observerr)
            {
                item.OnNext(data);
            }
        }
    }
}
