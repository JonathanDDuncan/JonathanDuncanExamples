using System;
using ServiceStack;
using JonathanDuncanExamples.ServiceModel;

namespace JonathanDuncanExamples.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
