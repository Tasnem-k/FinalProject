using System;
using System.Linq;

class Program
{
    static string[][] authors = {
        new[] { "Emily Henry", "Helen Hoang", "Ali Hazelwood" },
        new[] { "Khalid Hosseini", "Colleen Hoover", "Renee Ahdieh" },
        new[] { "Bell Hooks", "Illan Pappe", "Vaclav Smil" }
    };

    static string[][][] books = {
        new string[][] {
            new[] { "Book Lovers", "Beach Read", "Happy Place" },
            new[] { "The Kiss Quotient", "Bride's Test", "The Heart Principle" },
            new[] { "The Love Hypothesis", "Love on the Brain", "Love Theortically" }
        },
        new string[][] {
            new[] { "A thousand Splendid Suns", "The Kite Runner", "And the Mountains Echoed" },
            new[] { "It Ends With Us", "Verity", "It Starts With Us" },
            new[] { "The Wrath and The dawn", "The beautiful", "Flame in the Mist" }
        },
        new string[][] {
            new[] { "All About Love", "Ain't I a Women", "Belonging" },
            new[] { "Ten Myths About Isreal", "The Ethnic Cleansing of Palestine", "The Modern Middle East" },
            new[] { "Feeding the World", "Enrgy and Civilization", "Global Catastrophes and Trends: The Next Fifty Years" }
        }
    };

    static void Main()
    {
        while (true)
        {
            // Show the list of genres and ask the user to select one
            Console.WriteLine("Select a genre:");
            string[] genres = { "Romance", "Fiction", "Nonfiction" };
            for (int i = 0; i < genres.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {genres[i]}");
            }
            int genreIndex = int.Parse(Console.ReadLine()) - 1;

            // Show the list of authors for the selected genre and ask the user to select one
            Console.WriteLine($"Select an author from {genres[genreIndex]}:");
            string[] authorList = authors[genreIndex];
            for (int i = 0; i < authorList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {authorList[i]}");
            }
            int authorIndex = int.Parse(Console.ReadLine()) - 1;

            // Use LINQ to retrieve the list of books for the selected author
            var bookList = books[genreIndex][authorIndex];

            // Show the list of recommended books for the selected author
            Console.WriteLine($"Recommended books for {authorList[authorIndex]}:");
            for (int i = 0; i < bookList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {bookList[i]}");
            }

            // Ask if the user wants another recommendation
            Console.WriteLine("Do you want another recommendation? (Y/N)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "n")
            {
                return; // exit the program
            }
        }
    }
}






