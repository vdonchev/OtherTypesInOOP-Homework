namespace Attr
{
    using System;

    [Name("Mitko")]
    public class Student<T>
    {
        public Student<T> this[int index]
        {
            get
            {
                return new Student<T>();
            }
        }

        public void ShowInfo()
        {
            Type type = typeof(Student<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (object attr in allAttributes)
            {

                if (attr is NameAttribute)
                {
                    var name = (NameAttribute) attr;
                    Console.WriteLine(
                        "This class is written by {0}. ", name.Name);
                }
            }
        }
    }
}