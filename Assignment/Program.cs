using Assignment.Context;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbcontext dbcontext = new ITIDbcontext();

            //02 Add Migrition
            //01Add-Migration InitialCreate -context "ITIDbcontext"

        }
    }
}
 