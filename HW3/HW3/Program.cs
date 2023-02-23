// See https://aka.ms/new-console-template for more information






using System.Security.Principal;

namespace HW3
{
    public class QuestionSolution
    {
        public int [] GenerateNumbers(int length)
        {
            int[]numbers=new int[length];
            Random random= new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i]=random.Next(0,101);
            }
            return numbers;
        }
        public void ReverseNumber(ref int[] numbers)
        {
            for (int i=0;i<numbers.Length/2;i++) { 
                int firstNumber = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = firstNumber;
            }

        }
        public void PrintNumber(ref int[] numbers)
        {
            for (int i=0;i<numbers.Length;i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
        public void PrintFirstTenFibonacci()
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int previousOneNumber = secondNumber;
            int previousTwoNumber = firstNumber;
            Console.Write("First 10 Fibonacci numbers are: 1, 1, ");
            for (int i=3;i<=9;i++)
            {
                int currentNumber = previousOneNumber + previousTwoNumber;
                previousTwoNumber = previousOneNumber;
                previousOneNumber = currentNumber;

                Console.Write(currentNumber+", ");
            }
        }
        public int Fibonacci(int number)
        {
            if(number==1||number==2) { 
            return 1;}
            else { return Fibonacci(number - 1) + Fibonacci(number - 2); }

            
        }
    }
    public class Color
    {

        public int red
        {
            get
            {
                return red;
            }
            set
            {
                if (red <= 255 && red >= 0)
                {
                    red = value;
                }
            }
        }

        public int green
        {
            get
            {
                return green;
            }
            set
            {
                if (green <= 255 && green >= 0)
                {
                    green = value;
                }
            }
        }
        public int blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (blue <= 255 && blue >= 0)
                {
                    blue = value;
                }
            }
        }
        public int alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (alpha <= 255 && alpha >= 0)
                {
                    alpha = value;
                }
            }
        }
        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

        }
        public decimal GetGrayScale()
        {
            decimal grayScale = (red + green + blue) / 3;
            return grayScale;

        }


    }

    public class Ball
    {
        public int size { get; set; }
        Color color;
        //Color color = new Color(244, 100, 13);
        public int throwCount;
        public Ball(int size,Color color)
        {
            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }

        public void Pop()
        {
            size = 0;
        }
        public void ThrowBall()
        {
            if (size > 0)
            {
                throwCount++;
            }
        }
        public int ThrowCountNumber()
        {
            return throwCount;
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            QuestionSolution questionSolution= new QuestionSolution();

            //Console.Write("Enter the length of an array :");
            //int lengthArray = Int32.Parse(Console.ReadLine());
            //int [] numbers=new int[lengthArray];
            //numbers=questionSolution.GenerateNumbers(lengthArray);
            //Console.WriteLine($"Randomly Create {lengthArray} numbers for you");
            //questionSolution.PrintNumber(ref numbers);
            //Console.WriteLine("");
            //Console.WriteLine("After reversing these numbers");
            //questionSolution.ReverseNumber(ref numbers);
            //questionSolution.PrintNumber(ref numbers);


            //questionSolution.PrintFirstTenFibonacci();
            //Console.WriteLine(questionSolution.Fibonacci(10));


            //Ball ballOne = new Ball(10,new Color(233,2,3));
            //ballOne.ThrowBall();
            //ballOne.ThrowBall();
            //ballOne.ThrowBall();
            //Ball ballTwo = new Ball(11, new Color(23, 2, 3));
            //ballTwo.ThrowBall();
            //ballTwo.Pop();
            //ballTwo.ThrowBall();
            //Console.WriteLine(ballOne.ThrowCountNumber());
            //Console.WriteLine(ballTwo.ThrowCountNumber());

        }

    }
}
