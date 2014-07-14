using DependencyInjection.Common.Interfaces;

namespace DependencyInjection.Common.Classes
{
    public class Class2 : IOutput
    {
        public string TextToWrite()
        {
            return "Class2 output";
        }
    }
}
