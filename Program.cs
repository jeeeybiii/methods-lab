namespace MethodsLab
{
    class Program
    {
        /*private static int randomGeneratorOne, randomGeneratorTwo, answer, score = 0;
        private static Random rand = new Random();
        public static void Main(string[] args)
        {
            Questions();
            Console.ReadLine();

        }

        public static void Questions(){
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            Console.WriteLine($"You have scored: {score}");
        }

        public static void QuestionOne()
        {

            randomGeneratorOne = rand.Next(1, 100);
            randomGeneratorTwo = rand.Next(1, 100);
            Console.Write($"What is {randomGeneratorOne} + {randomGeneratorTwo}? ");
            answer = int.Parse(Console.ReadLine());
            if(answer == (randomGeneratorOne + randomGeneratorTwo))
            {
                score++;
                Console.WriteLine("Your answer is correct!");
            }
            else
            {
                Console.WriteLine("Wrong answer!");
            }
            
        }
        
        public static void QuestionTwo()
        {
            randomGeneratorOne = rand.Next(1, 100);
            randomGeneratorTwo = rand.Next(1, 100);
            Console.Write($"What is {randomGeneratorOne} - {randomGeneratorTwo}? ");
            answer = int.Parse(Console.ReadLine());
            if(answer == (randomGeneratorOne - randomGeneratorTwo))
            {
                Console.WriteLine("Your answer is correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong answer!");
            }
        }

        public static void QuestionThree()
        {
            randomGeneratorOne = rand.Next(1, 10);
            randomGeneratorTwo = rand.Next(1, 10);
            Console.Write($"What is {randomGeneratorOne} * {randomGeneratorTwo}? ");
            answer = int.Parse(Console.ReadLine());
            if (answer == (randomGeneratorOne * randomGeneratorTwo))
            {
                Console.WriteLine("Your answer is correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong answer!");
            }
        }

     */

        //Program 3 - Litres of paint
        //public static void Main(string[] args){
        //    Console.WriteLine("Litres of paint!");
        //    Results();
        //}

        ////Method One variables
        //private static double length, width, height;

        ////Method 2 variables
        //public static double area, squareMeters, paintLitres;

        //public static void UserInput()
        //{
        //    Console.Write("Enter length: ");
        //    length = double.Parse(Console.ReadLine());

        //    Console.Write("Enter width: ");
        //    width = double.Parse(Console.ReadLine());

        //    Console.Write("Enter height: ");
        //    height = double.Parse(Console.ReadLine());
        //}

        //public static void Calculations()
        //{
        //    UserInput();
        //    area = (2 * width * height) + (2 * length * height) + (length * width);
        //    squareMeters = 2 * area;
        //    paintLitres = squareMeters / 20;
        //    paintLitres = Math.Round(paintLitres);
        //}

        //public static void Results()
        //{
        //    Calculations();
        //    Console.WriteLine($"Area: {area:f2}");
        //    Console.WriteLine($"Square Meters: {squareMeters:f2}");
        //    Console.WriteLine($"Litres of Paint: {paintLitres}");
        //}


        private static int userChoice;
        public static void Main(string[] args)
        {
            //Skeleton Program
            do
            {
                Output();
            } while (userChoice != 0);
        }

        public static void TaskOne()
        {
            Console.WriteLine("This is task 1\n");
        }

        public static void TaskTwo()
        {
            Console.WriteLine("This is task 2\n");
        }

        public static void TaskThree()
        {
            Console.WriteLine("This is task 3\n");
        }

        public static void TaskFour()
        {
            Console.WriteLine("This is task 4\n");
        }
        public static void TaskZero()
        {
            Console.WriteLine("Exiting program. Thank you and have a good day!\n");
            Environment.Exit(0);
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Wrong input! Please try again!\n");
        }

        public static void TaskChoices()
        {
            Console.WriteLine("Task 1 - 1");
            Console.WriteLine("Task 2 - 2");
            Console.WriteLine("Task 3 - 3");
            Console.WriteLine("Task 4 - 4");
            Console.WriteLine("Exit menu system - 0");
            Console.Write("Please Enter a task number: ");
            userChoice = int.Parse(Console.ReadLine());
        }

        public static void Output()
        {
            TaskChoices();
            switch (userChoice)
            {
                case 1:
                    TaskOne();
                    break;
                case 2:
                    TaskTwo();
                    break;
                case 3:
                    TaskThree();
                    break;
                case 4:
                    TaskFour();
                    break;
                case 0:
                    TaskZero();
                    break;
                default:
                    ErrorMessage();
                    break;
            }
        }
    }
}
