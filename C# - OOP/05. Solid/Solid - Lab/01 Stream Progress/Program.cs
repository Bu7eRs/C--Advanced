using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
	        IProgressable movie = new Movie();

	        movie.Length = 5;
	        Console.WriteLine(movie.Length);
        }
    }
}
