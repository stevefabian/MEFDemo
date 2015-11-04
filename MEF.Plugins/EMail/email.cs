using System.ComponentModel.Composition;
using MEF.Contracts;

namespace MEF.Plugin
{
    [Export(typeof(IContactMethod))]
    public class EMail : IContactMethod
    {
        public string Name { get; set; }

        public string Contact(string msg)
        {
            return "Email sent.";
        }

        public EMail()
        {
            Name = "Email";
        }
    }
}
