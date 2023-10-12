using LibraryEF_Context.Contexts;

namespace LibraryEF_Context
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDbContext libraryDbContext = new LibraryDbContext();
        }
    }
}