using Final_Project;


class program
{
    public static void RecommendBook(List<Author> authors)
    {


        //prompts for genre selection 
        Console.WriteLine(" What kind of genre would you like to read?");
        Console.WriteLine("1. Romance");
        Console.WriteLine("2. Fiction");
        Console.WriteLine("3. Non-fiction");
        // reading user's choice 
        string genreChoice = Console.ReadLine();
        //prompt for selecting an author 
        Console.WriteLine("Please select an author from the following options:");
        Console.WriteLine("1.Jane Austin");
        Console.WriteLine("2. Khalid Hoessini");
        Console.WriteLine("3. Bell Hooks");
        Console.WriteLine("4. Emily Henry");
        Console.WriteLine("5. Colleen Hoover");
        Console.WriteLine("6. Ilan Pappe");
        // reading user's choice 
        string authorChoice = Console.ReadLine();
        if (authorChoice == "1")
        {
            Console.WriteLine("Pride and Prejudice");
        }
        // finding the selected author
        //var selectedAuthor = authors.FirstOrDefault(a => a.Name == authorChoice && a.Genre.Name == genreChoice);

        // validating the selected author
        //if (selectedAuthor == null)
        //{
        //    Console.WriteLine("Invalid author selection. Please try again.");
        //return;
        // }


    }

    [STAThread]
    static void Main(string[] args)
    {
        var romanceGenre = new Genre { Name = "Romance" };
        var fictionGenre = new Genre { Name = "Fiction" };
        var nonfictionGenre = new Genre { Name = "Nonfiction" };


        var authors = new List<Author>
        {
            new Author { Name = "Jane Austin", Genre = romanceGenre },
            new Author { Name = "Khalid Hoessini", Genre = fictionGenre },
            new Author { Name = "Bell Hooks", Genre = nonfictionGenre },
            new Author { Name = "Emily Henry", Genre = romanceGenre },
            new Author { Name = "Colleen Hoover", Genre = fictionGenre },
            new Author { Name = "Ilan Pappe", Genre = nonfictionGenre },
            //add more authors 

        };

        var books = new List<Book>
        {
            new Book { Title = "Pride and Prejudice", Author = authors[0] },
            new Book { Title = "Emma", Author = authors[0] },
            new Book { Title = "The Kite Runner", Author = authors[1] },
            new Book { Title = "A Thousand Splendid Suns", Author = authors[1] },
            new Book { Title = "All About Love", Author = authors[2] },
            new Book { Title = "Feminism is For Everybody", Author = authors[2] },
            //add more books
        };
        //welcome message
        Console.WriteLine(" Welcome to our book recommendation chat box!");
        while (true)
        {
            RecommendBook(authors);
            Console.WriteLine("Would you like another recommendation? (Y/N)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                break;
            }

        }
    }
}


