using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEF.Contracts;

namespace MEF.Plugin
{
    [Export(typeof(IContactMethod))]
    public class Call : IContactMethod
    {
        public string Name { get; set; }

        public string Contact(string msg)
        {
            return "Phone call initiated.";
        }

        public Call()
        {
            Name = "Phone call";
        }
    }
}
