using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Interface;

namespace PresentationLayer.Observer
{
    public class Observer : IObserver
    {
        Label Label;
        List<List> obs;
        public string x;
        public Observer(Label label)
        {
            obs = new List<List>();
            this.Label = label;
        }
        public void OnNext(string data)
        {
            obs.Add(new List(data));
        }

        public void Update(string data)
        {
            x = "Vald tema: ";
            Label.Text = x + data;
        }
    }
}
