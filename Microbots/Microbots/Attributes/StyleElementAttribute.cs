using System;

namespace Microbots.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class StyleElementAttribute : Attribute
    {
        public string Key { get; set; }

        public StyleElementAttribute() : this(null) { }

        public StyleElementAttribute(string key)
        {
            Key = key;
        }
    }
}
