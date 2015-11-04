using System.ComponentModel.Composition;
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
