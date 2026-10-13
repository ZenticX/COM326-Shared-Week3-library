using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "Bill Gates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class

// Bisplay all the items in the Book list
foreach (Book book in books)
{
    book.DisplayInfo();
}
foreach (Member member in members)
{
    member.DisplayInfo();
}