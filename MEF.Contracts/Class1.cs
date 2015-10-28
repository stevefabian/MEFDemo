using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEF.Contracts
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ImportMany(typeof(IContactMethod))]
        public List<IContactMethod> ContactMethods { get; set; }

        public Person()
        {
            var catalog = new DirectoryCatalog(@"Plugins");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }

    public interface IContactMethod
    {
        string Name { get; set; }
        string Contact(string msg);
    }
}
