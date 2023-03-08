namespace SelectionStatementsExercise2
{
    public class Program
    {
        public static void SubjectSelection()
        {
            //definine userInput variable as string
            string? userInput;

            //user input
            Console.WriteLine("What was your favorite subject while you were in school?");
            userInput = Console.ReadLine();

            //switch case section


            switch (userInput.ToLower())
            {
                case "calculus":
                case "math":
                case "arithmetic":
                    Console.WriteLine("I've got a huge amount of appreciation for any arithmetic studies, very cool!");
                    break;

                case "science":
                case "biology":
                case "chemistry":
                Console.WriteLine($"The sciences are very imporant, especially {userInput}. I'm glad to hear that!");
                    break;

                case "geography":
                    Console.WriteLine($"That's one of my strongest subjects too! {userInput} was a ton of fun.");
                    break;

                case "economics":
                    Console.WriteLine("What an important class, economics should cetainly be a mandatory topic.");
                    break;

                case "literature":
                case "english":
                case "language studies":
                    Console.WriteLine("That was my absolute favorite in school, I love literature studies!");
                    break;

                    // default case vvvvvv

                default:
                    Console.WriteLine($"That's cool, I've never taken {userInput} before. I'm interested to hear more about it!");
                    break;

            }
           



        }
        static void Main(string[] args)
        {

            //calling method


            SubjectSelection();

        }
    }
}