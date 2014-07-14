using DependencyInjection.Common.Interfaces;

namespace DependencyInjection.Common.Classes
{
    public class Class1 : IOutput
    {
        public string TextToWrite()
        {
            return "Class1 output";
        }
    }
}
