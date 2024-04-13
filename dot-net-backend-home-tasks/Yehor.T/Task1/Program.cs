namespace Task1;

internal sealed class Program
{
    private static bool PrintMenu(out int selected)
    {
        Console.Write("1 - create and submit student.\n2 - submit random range of sutdents." +
                      "\n3 - task 1.\nany other to exit.\n\nAnswer -> ");
       
        if (int.TryParse(Console.ReadLine(), out selected))
        {
            return false;
        }

        return true;
    }
    
    public static void Main(string[] args)
    {

        var studList = new LinkedList<Student>();
        while (true)
        {
            Console.WriteLine($"Total Elements - {studList.Count}");
            if (PrintMenu(out var selectedItem))
            {
                Console.WriteLine("Exiting...");
                break;
            }
            
            switch (selectedItem)
            {
                case 1:
                {
                    StudentExtensions.Init(out var stud, Console.ReadLine, Console.Write);
                    studList.AddLast(stud);
                } break;

                case 2:
                {
                    UintExtensions.InitUintWithMessage(out var number, "Enter number to random init: ");

                    foreach (var item in StudentExtensions.InitRandomRange(number))
                    {
                        studList.AddLast(item); 
                    }

                    Console.WriteLine("Random values initialised.");
                    Thread.Sleep(1000);
                } break;

                case 3:
                {
                    UintExtensions.InitUintWithMessage(out var number, "Enter rating: ");
                    
                    byte age;
                    do
                    {
                        Console.Write("\nEnter student's age: ");
                    } while (!byte.TryParse(Console.ReadLine(), out age) || age == 0);
                    
                    foreach (var item in studList)
                    {
                        if (item.Rating >= number && item.Age > age)
                        {
                            Console.WriteLine(item.GetFormattedString());
                        }
                    }

                    Console.ReadLine();
                } break;
            }
            
            Console.Clear();
        }
    }
}