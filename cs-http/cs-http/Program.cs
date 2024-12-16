namespace cs_http
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            Response responses = await APICalls.GetBooksAsync();
            foreach(var book in responses.Results)
            {
                Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author}");
            }
        }
    }
}
