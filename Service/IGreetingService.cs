namespace WebAPICore.Service
{
    public interface IGreetingService
    {
        string GetGreeting();
        string GetPersonalGreeting(string name);
        string PostPersonalGreeting(string name);

    }
}
