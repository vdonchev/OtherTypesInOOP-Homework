namespace _03.GenericList
{
    using System;

    public static class ProgramMain
    {
        public static void Main()
        {
            GenericList<int> genericList = new GenericList<int>(5) { 1, 2, 3, 100 };
            Print(genericList, "New GenericList");

            // Clear
            genericList.Clear();
            Print(genericList, "Clear");

            // Add
            genericList.Add(1);
            genericList.Add(3);
            genericList.Add(69);
            Print(genericList, "Add // 1, 3, 69");

            // Remove by index
            genericList.RemoveAt(2); // will remove 69
            Print(genericList, "RemoveAt // index 2");

            // Add range
            genericList.AddRange(100, 200, 300, 400);
            Print(genericList, "Add range // 100, 200, 300, 400");

            // Insert on specific index
            genericList[0] = 69;
            Print(genericList, "Insert at index // 0");

            // Print element that is on specific index
            Print(genericList[0], "Show by index // 0");

            // Get item's index, if item not presented returns -1 
            Print(genericList.GetIndex(100), "Find item's index // 100");
            Print(genericList.GetIndex(1000), "Find item's index // 1000");

            // Contains
            Print(genericList.Contains(300), "Check if collaction contains // 300");
            Print(genericList.Contains(3000), "Check if collaction contains // 3000");

            // Show total capacity
            Print(genericList.Capacity, "Collection capacity");

            // Show size
            Print(genericList.Size, "Collection size");
            
            // Minimum, extension generic method
            genericList.Add(-5);
            Print(genericList.Minimum(), "Find min element");

            //Maximum, extension generic method
            Print(genericList.Maximum(), "Find max element");

            // New generic list of DateTime
            IGenericList<DateTime> dates = new GenericList<DateTime>();
            dates.Add(DateTime.MaxValue);
            dates.Add(DateTime.Now);

            Print(dates, "Print dates");
        }

        private static void Print<T>(IGenericList<T> genericList, string title = "Generic List")
        {
            Console.WriteLine(
                "-> "
                + title
                + Environment.NewLine
                + genericList
                + Environment.NewLine);
        }

        private static void Print<T>(T item, string title = "Print")
        {
            Console.WriteLine(
                "-> "
                + title
                + Environment.NewLine
                + item
                + Environment.NewLine);
        }
    }
}
