namespace _04.GenericListVersion
{
    using System;
    using _03.GenericList;

    public static class Program
    {
        public static void Main()
        {
            IGenericList<string> list = new GenericList<string>();
            list.Add("Hello");

            // Will return GenericList class Version attribute at runtime using reflection
            // both GenericList<T> and VersionAttribute classes are in "03.GenericList" project
            Console.WriteLine(list.Version());
        }
    }
}