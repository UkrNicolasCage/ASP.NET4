using WebApplicationn5.Services;

namespace WebApplicationn5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IBooksService, BooksService>();
            builder.Services.AddSingleton<IUsersService, UsersService>();

            
            var app = builder.Build();

            app.Map("/", () => "Index Page");

            app.Map("/Library", () => "Welcome to the Library!");

            app.Map("/Library/Books", (IBooksService booksService) => $"Books:      \n{booksService.GetBooks()}");

            app.Map("/Library/Profile", (IUsersService usersService) => $"Info:     \n{usersService.GetCurrentUser()}");

            app.Map("/Library/Profile/{id}", (int id, IUsersService usersService) => $"{usersService.GetUserByID(id)}");

            app.Run();
        }


    }
}