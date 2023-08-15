namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "english":
                    Console.WriteLine("English is always an interesting subject!");
                    break;
                case "history":
                    Console.WriteLine("History is a difficult subject, so much to remember");
                    break;
                case "p.e.":                
                    Console.WriteLine("P.E. is always good to get you up and moving!");
                    break;
                case "pe":
                    Console.WriteLine("P.E. is always good to get you up and moving!");
                    break;
                default:
                    Console.WriteLine($"Wow! I havent taken that subject before! {subject} sounds fun!");
                    break;
           
            }
        }
    }
}