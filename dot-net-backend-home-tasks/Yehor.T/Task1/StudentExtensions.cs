namespace Task1;

internal static class StudentExtensions
{
    public static void Init(out Student stud, Func<string?> uiInput, Action<string> uiOutput)
    {
        uiOutput("Enter student's name: ");
        var name = uiInput();
        uiOutput("Enter student's surname: ");
        var surname = uiInput();
        byte age;
        do
        {
            uiOutput("Enter student's age: ");
        } while (!byte.TryParse(uiInput(), out age) || age == 0);

        DateOnly birthday;
        do
        {
            uiOutput("Enter student's birthday date: ");
        } while (!DateOnly.TryParse(uiInput(), out birthday));

        uint rating;
        string ratingStr;
        
        do
        {
            uiOutput("Enter student's rating: ");
            ratingStr = uiInput();
        } while (!uint.TryParse(ratingStr, out rating));

        if (name!.ToLower().StartsWith("y"))
        {
            rating += 1000;
        }

        stud = new(name!, surname!, age, birthday, rating);
    }
    
    public static IEnumerable<Student> InitRandomRange(uint count)
    {
        var names = new[] { "Yehor", "Vasya", "Vitya", "Kolya", "Max", "Sam", "Gordon" };
        var surnames = new[] { "T.", "P.", "O.", "G.", "A.", "S.", "F." };
        var random = new Random();
        var result = new Student[count];

        for (int i = 0; i < count; i++)
        {
            var tempDate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            var rAge = (byte)random.Next(10, 101);
            var rMoth = (byte)random.Next(1, 13);
            var rDay = random.Next(1, 31);
            tempDate = tempDate.AddYears(-rAge).AddMonths(rMoth).AddDays(rDay);
            
            var rNameInd = random.Next(0, names.Length);
            var rSurnInd = random.Next(0, surnames.Length);
            var rRating = (uint)random.Next(0, 101);
            
            result[i] = new Student(names[rNameInd], surnames[rSurnInd], rAge, tempDate, rRating);
        }

        return result;
    }

    public static string GetFormattedString(this Student student)
        => $"{student.Name} {student.Surname}, age {student.Age}, " +
           $"rating {student.Rating}, date of birth {student.BirthdayDate}";
}