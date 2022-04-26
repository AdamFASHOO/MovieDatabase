namespace MovieDatabase
{
    public class Program
    {
        public static void Main()
        {
            Helper h = new Helper();

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are 10 movies in this list.");

            bool runAgain = true;
            while (runAgain)
            {
                Movie starWars = new Movie("Star wars", "Scifi");
                Movie theMatrix = new Movie("The Matrix", "Scifi");
                Movie interstellar = new Movie("Interstellar", "Scifi");
                Movie hotRod = new Movie("Hot Rod", "Comedy");
                Movie superbad = new Movie("Superbad", "Comedy");
                Movie talladegaNights = new Movie("Talladega Nights", "Comedy");
                Movie theInterview = new Movie("The Interview", "Comedy");
                Movie darknessFalls = new Movie("Darkness Falls", "Horror");
                Movie scream = new Movie("Scream", "Horror");
                Movie theNumber23 = new Movie("The Number 23", "Horror");

                List<Movie> movieList = new List<Movie>() { starWars, theMatrix, interstellar, hotRod, superbad, talladegaNights, theInterview, darknessFalls, scream, theNumber23 };

                string input = h.GetUserInput("What category are you interested in?").ToLower().Trim();
                Console.WriteLine();

                if (input == "scifi")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category.Contains("Scifi"))
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else if (input == "comedy")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category.Contains("Comedy"))
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else if (input == "horror")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category.Contains("Horror"))
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry but that category isn't currently listed, please try again.");
                    continue;
                }
                Console.WriteLine();
                runAgain = h.RunAgain();
            }
        }
    }
}