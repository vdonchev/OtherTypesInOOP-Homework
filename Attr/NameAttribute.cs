namespace Attr
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public class NameAttribute : Attribute
    {
        public string Name { get; set; }

        public NameAttribute(string name)
        {
            this.Name = name;
        }
    }
}