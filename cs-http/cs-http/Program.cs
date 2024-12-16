namespace cs_http
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            //Response responses = await APICalls.GetBooksAsync(5);
            //foreach(var book in responses.Results)
            //{
            //    Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author}");
            //}

            ResponseFlight responses = await APICallsFlight.GetFlightAsync();
            Console.WriteLine(responses.Flights.);

        }
    }
}
