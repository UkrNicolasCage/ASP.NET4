namespace WebApplicationn5
{
    public class BookInfo
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Genre { get; set; } = "";

        public override string ToString()
        {
            return $"Id: {Id},\n Title: {Title},\n Author: {Author},\n Genre: {Genre}.\n";
        }
    }
}

