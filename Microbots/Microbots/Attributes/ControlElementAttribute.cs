using System;

namespace Microbots.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class ControlElementAttribute : Attribute
    {
        public string Name { get; set; }

        public ControlElementAttribute() : this(null) { }

        public ControlElementAttribute(string name)
        {
            Name = name;
        }
    }
}
