using Final_Project;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    static string[][] authors = {
        new[] { "Emily Henry", "Helen Hoang", "Ali Hazelwood" },
        new[] { "Khalid Hosseini", "Colleen Hoover", "Renee Ahdieh" },
        new[] { "Bell Hooks", "Illan Pappe", "Vaclav Smil" }
    };

    static Book [][][] books = {
        new Book [][] {
            new Book[] { new Book ("Book Lovers",2022), new Book ("Beach Read",2021), new Book ("Happy Place",2023) },
            new Book [] { new Book ("The Kiss Quotient",2020), new Book ("Bride's Test",2021), new Book("The Heart Principle", 2022) },
            new Book [] { new Book ("The Love Hypothesis",2019), new Book("Love on the Brain",2022), new Book("Love Theortically", 2023) }
        },
        new Book[][] {
            new Book [] { new Book ("A thousand Splendid Suns",2007), new Book ("The Kite Runner",2003), new Book("And the Mountains Echoed", 2013) },
            new Book [] {new Book("It Ends With Us",2016), new Book ("Verity",2018), new Book("It Starts With Us", 2022) },
            new Book [] { new Book("The Wrath and The dawn",2015), new Book("The beautiful",2019), new Book("Flame in the Mist", 2017) }
        },
        new Book[][] {
            new Book[] {new Book ("All About Love",2000), new Book("Ain't I a Women",1981), new Book("Belonging",2009) },
            new Book [] {new Book ("Ten Myths About Isreal",2017), new Book("The Ethnic Cleansing of Palestine",2006), new Book( "The Modern Middle East", 2006) },
            new Book [] { new Book ("Feeding the World",2000), new Book( "Enrgy and Civilization",2017), new Book ( "Global Catastrophes and Trends: The Next Fifty Years",2010) }
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
                Console.WriteLine($"{i + 1}.{bookList[i]}");
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






