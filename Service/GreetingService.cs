using Microsoft.AspNetCore.Mvc;

namespace WebAPICore.Service
{
    public class GreetingService: IGreetingService
    {
        public string GetGreeting() => "Hello, welcome to ASP.NET Core Web API!";
        public string GetPersonalGreeting(string name) => $"Hello {name}, welcome to ASP.NET Core Web API!";
        public string PostPersonalGreeting(string name) => $"Hello {name}, welcome to ASP.NET Core Web API!";

    }
}
