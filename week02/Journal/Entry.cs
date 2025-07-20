public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;
        _response = response; 
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}");
    }
}