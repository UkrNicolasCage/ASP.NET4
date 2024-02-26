using System.Text.Json;
using System.Text;

namespace WebApplicationn5.Services
{



    public class BooksService : IBooksService
    {
        private readonly BooksResponse _response;
        public BooksService()
        {
            string jsonString = File.ReadAllText("booksInfo.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _response = JsonSerializer.Deserialize<BooksResponse>(jsonString, options);
        }
        public string GetBooks()
        {
            if (_response is null)
            {
                throw new InvalidOperationException("An error occurred while attempting to read the JSON file.");
            }

            StringBuilder booksString = new StringBuilder();

            foreach (var book in _response.Books)
            {
                booksString.AppendLine(book.ToString());
            }

            return booksString.ToString();
        }

    }

}
