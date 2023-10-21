namespace _23oct_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> programmingLanguages = new Dictionary<string, DateTime>();

           
            programmingLanguages.Add("C#", new DateTime(2000, 1, 1));
            programmingLanguages.Add("Python", new DateTime(1991, 2, 20));
            programmingLanguages.Add("Java", new DateTime(1995, 5, 23));
            programmingLanguages.Add("JavaScript", new DateTime(1995, 12, 4));
            programmingLanguages.Add("C++", new DateTime(1983, 10, 1));
            

            
            var sortedLanguages = programmingLanguages.OrderBy(x => x.Value);

            
            foreach (var language in sortedLanguages)
            {
                Console.WriteLine($"Proqramlashdirma dili: {language.Key}  |   Yaradildigi tarix: {language.Value}");
            }
        }
    }
}