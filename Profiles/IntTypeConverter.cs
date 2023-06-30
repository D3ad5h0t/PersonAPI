using AutoMapper;

namespace PersonAPI.Profiles
{
    public class IntTypeConverter : ITypeConverter<string, int>
    {
        public int Convert(string source, int destination, ResolutionContext context)
        {
            var converterInt = 1;

            try
            {
                converterInt = System.Convert.ToInt32(source);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Whoops! Error converting: {ex.Message}");
            }

            return converterInt;
        }
    }
}