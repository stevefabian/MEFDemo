﻿using System.ComponentModel.Composition;
using MEF.Contracts;

namespace MEF.Plugin
{
    [Export(typeof(IContactMethod))]
    public class TextMessage : IContactMethod
    {
        public string Name { get; set; }

        public string Contact(string msg)
        {
            return "Text Message sent.";
        }

        public TextMessage()
        {
            Name = "Text Message";
        }
    }
}
