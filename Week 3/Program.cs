class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void Displayinfo()
    {
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title : {Title}");
        Console.WriteLine($"Book author : {Author}");
        Console.WriteLine($"Book ISBN : {ISBN}");
        Console.WriteLine($"Book NoOfPages : {NoOfPages}");
        Console.WriteLine();
    }


    static void Main (string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for begginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456677";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "12345";
        book2.NoOfPages = 50;

        // Output the book information to the console
        book.Displayinfo();
        book2.Displayinfo();

        
    }
}
