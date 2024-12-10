using Pendik.WebMvc.Models;

namespace Pendik.WebMvc.Data;

public class BookData
{

    public static List<Book> Books { get; set; } = new List<Book> {new Book{Id =1, Description="Deneme",Price=250,Title="Deneme"}};

}
