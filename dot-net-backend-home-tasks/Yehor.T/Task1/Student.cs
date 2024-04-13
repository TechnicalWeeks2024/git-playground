namespace Task1;

internal readonly record struct Student
    (string Name, string Surname, byte Age, DateOnly BirthdayDate, uint Rating);