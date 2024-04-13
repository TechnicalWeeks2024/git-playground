namespace Task1;

internal static class UintExtensions
{
    public static void InitUintWithMessage(out uint value, string message)
    {
        do
        {
            Console.Write(message);
        } while (!uint.TryParse(Console.ReadLine(), out value));
    }
}