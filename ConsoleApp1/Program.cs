using System.Runtime.InteropServices;



public class Program
{
    [DllImport(@"C:\Users\m.barini\Desktop\Projects\cs_call_rust\target\debug\our_rust.dll")]
    private static extern int hello_world();


    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(hello_world());
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message); ;
        }
    }
}