using System.Text;
using System.Text.Json;


var request = new Request() { 
    BaseUrl = "https://jsonplaceholder.typicode.com/"
};
//request.BaseUrl = "https://jsonplaceholder.typicode.com/";

var res = await request.MakeRequest("todos/1");

Console.WriteLine(res);
Console.ReadLine();


class Request
{
    public required string BaseUrl { get; set; }
    public HttpMethod Method { get; set; } = HttpMethod.Get;
    public async Task<string> MakeRequest(string url, object body = null)
    {
        using var client = new HttpClient();
        var request = new HttpRequestMessage(Method, url);
        if (body is not null)
        {
            var json = JsonSerializer.Serialize(body);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
        }
        var response = await client.SendAsync(request);
        return await response.Content.ReadAsStringAsync();
    }
}