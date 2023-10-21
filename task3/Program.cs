namespace _23oct_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Library> libraries = new List<Library>();
            List<Category> categoriess = new List<Category>();
            List<Book> books = new List<Book>();

            while (true) 
            { 

            Console.WriteLine("=================");
            Console.WriteLine("     Ana Menyu   ");
            Console.WriteLine("=================");
            Console.WriteLine("[1]  Yeni kitabxana yarat");
            Console.WriteLine("[2]  Yeni kateqoriya yarat");
            Console.WriteLine("[3]  Yeni kitab yarat");
            Console.WriteLine("[4]  Kitabxanaya daxil ol");
            Console.WriteLine("[5]  Proqramdan chix");
            Console.WriteLine(">>>");

            string input=Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Kitabxananin adini daxil et:");
                        string libraryName = Console.ReadLine();
                        Library newLibrary = new Library(libraryName);
                        libraries.Add(newLibrary);
                        Console.WriteLine($"'{libraryName}' adli kitabxana yaradildi");
                        break;
                    case "2":
                        Console.WriteLine("Kateqoriya adini daxil et:");
                        string categoryName = Console.ReadLine();
                        Category newCategory = new Category(categoryName);
                        categoriess.Add(newCategory);
                        Console.WriteLine($"'{categoryName}' adli kateqoriya yaradildi");
                        break;
                    case "3":
                        Console.WriteLine("================");
                        Console.WriteLine("Yeni kitab yarat");
                        Console.WriteLine("================");
                        Console.WriteLine("Kitabin adini daxil et:");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("Kitabin yazicisi kimdir?");
                        string authorName = Console.ReadLine();
                        Console.WriteLine("Kateqoriya sechin:");
                        foreach (Category category in categoriess)
                        {
                            Console.WriteLine($"Id: {category.Id}  |  Name: {category.Name}");
                        }
                        int choosenCategoryId = int.Parse(Console.ReadLine());
                        if (choosenCategoryId <= 0 || choosenCategoryId > categoriess.Count)
                        {
                            throw new CategoryNotFoundException("Kateqoriya tapilmadi.");
                        }

                        Category choosenCategory = categoriess[choosenCategoryId - 1];
                        Book newBook = new Book(bookName, authorName, choosenCategory);
                        books.Add(newBook);
                        Console.WriteLine($"'{bookName}' adli kitab '{choosenCategory.Name}' kateqoriyasina elave edildi");
                        break;
                    case "4":
                        Console.WriteLine("Kitabxana secin");
                        foreach (Library library in libraries)
                        {
                            Console.WriteLine($"Id: {library.Id}  |  Name: {library.Name}");
                        }
                        int choosenLibraryId = int.Parse(Console.ReadLine());
                        if (choosenLibraryId <= 0 || choosenLibraryId > libraries.Count)
                        {
                            throw new LibraryNotFoundException("Kitabxana tapilmadi.");
                        }
                        Library choosenLibrary = libraries[choosenLibraryId - 1];
                        while (true)
                        {
                            Console.WriteLine("Kitabxana menyusu:");
                            Console.WriteLine("[1] Kitablari elave et");
                            Console.WriteLine("[2] Kitablari goster");
                            Console.WriteLine("[0] Kitabxanadan chix");
                            Console.WriteLine(">>>");

                            string libraryInput = Console.ReadLine();
                            switch (libraryInput)
                            {
                                case "1":
                                    Console.WriteLine("Elave edeceyiniz kitabi sechin:");
                                    foreach (Book book in books)
                                    {
                                        Console.WriteLine($"Id: {book.Id} | Name: {book.Name} | Authot: {book.Author}");
                                    }
                                    int choosenBookId = int.Parse(Console.ReadLine());
                                    if (choosenBookId <= 0 || choosenBookId > books.Count)
                                    {
                                        throw new BookNotFoundException("Kitab tapilmadi.");
                                    }
                                    Book choosenBook = books[choosenBookId - 1];
                                    try
                                    {
                                        choosenLibrary.AddBook(choosenBook);
                                        Console.WriteLine($"'{choosenBook.Name}' adli kitab '{choosenLibrary.Name}' adli kitabxanaya elave edildi.");
                                    }
                                    catch (BookAlreadyExistException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine($"'{choosenLibrary.Name}' kitabxanasindaki kitablar:");
                                    choosenLibrary.ListAllBooks();
                                    break;
                                case "3":
                                    break;
                                default:
                                    throw new WrongInputException("Yalnish deyer");
                            }

                            if (libraryInput == "3")
                            {
                                break;
                            }
                        }
                        break;

                    case "5":
                        break;
                    default:
                        throw new WrongInputException("Yalnish deyer");

                }

            }
        }
    }
}