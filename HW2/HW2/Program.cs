// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace HW1
{
    public class QuestionSolution
    {
        public void CopyingAnArray()
        {
            int[] originalArray = { 1, 2,3,4,5,6,7,8,9,10 };
            int lengthProperty = originalArray.Length;
            int[] copyOriginalArray = new int[lengthProperty];
            for(int i=0; i<lengthProperty; i++)
            {
                copyOriginalArray[i]= originalArray[i];
                
            }
            Console.Write("originalArray: ");
            for (int i = 0; i < lengthProperty; i++)
            {
                Console.Write(originalArray[i]+" ");

            }
            Console.WriteLine("");
            Console.Write("copyOriginalArray: ");
            for (int i = 0; i < lengthProperty; i++)
            {
                Console.Write(copyOriginalArray[i]+" ");

            }

        }


        public void GroceryList()
        {
            List<string> groceryList=new List<string>();

            while (true)
            {
                Console.WriteLine("Grocery List: ");

                foreach(string item in groceryList)
                {
                    Console.WriteLine(" "+item);
                }
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input= Console.ReadLine();

                if (input.StartsWith("+"))
                {
                    string item= input.Substring(1).Trim();
                    groceryList.Add(item);
                }
                else if (input == "--")
                {
                    groceryList.Clear();
                }
                else if (input.StartsWith("-"))
                {
                    string item=input.Substring(1).Trim();
                    groceryList.Remove(item);
                }
                
                else
                {
                    Console.WriteLine("Invalid; Please Enter command (+ item, - item, or -- to clear))");
                }
            }
        }

        public int[] FindPrimesInRange(int startNum, int endNum)
        {

            if((startNum<0 || endNum < 0) || (startNum > endNum))
            {
                Console.WriteLine("Invalid Input");
            }
            List<int> output = new List<int>();
            for (int i= startNum; i<= endNum; i++)
            {
                bool isPrime = true;

                for (int j=2;j<=Math.Sqrt(i);j++)
                {
                    if (i%j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    output.Add(i);
                }
            }
            return output.ToArray();
        }

        public int[] Rotation(int[] numbers,int k)
        {
            int[] rotationArray = new int[numbers.Length];
            int[] outPut = new int[numbers.Length];
            for (int i=0;i< numbers.Length;i++)
            {
                int value = (i + k) % numbers.Length;
                rotationArray[i] =numbers[value];
            }
            for(int j=0;j< rotationArray.Length; j++)
            {
                outPut[j] = rotationArray[j] + rotationArray[(j + 1) % rotationArray.Length];
            }
            return outPut;
        }


        public void LongestSequenceOfEqualElements(int[] numbers)
        {
            int maxLength = 0;
            int sequencesNumber=-1;
            int count = 1;

            for(int i=0;i<numbers.Length-1;i++) { 
                
                if (numbers[i] == numbers[i+1]) {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count>maxLength)
                {
                    maxLength = count;
                    sequencesNumber = numbers[i];
                }
            
            }

            for(int j=0;j<maxLength;j++)
            {
                Console.Write(sequencesNumber+" ");
            }

            
        }
        public void MostFrequentNumber(int[] numbers)
        {
            int maxLength = 0;
            int mostFrequentNumber = -1;
            for (int i=0;i< numbers.Length;i++)
            {
                int count = 0;
                for(int j=0;j<numbers.Length;j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count>maxLength) { 
                    maxLength = count;
                    mostFrequentNumber = numbers[i]; 
                }
            }
            Console.WriteLine("The most frequent number is " + mostFrequentNumber);
        }

        public void ReverseStringFirstMethod()
        {
            Console.WriteLine("Please type a string you want to reverse: ");
            string reverseString=Console.ReadLine();
            char[] arr = new char[reverseString.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = reverseString[i];
            }
            Array.Reverse(arr);
            Console.WriteLine(arr.ToArray());

        }

        public void ReverseStringSecondMethod()
        {
            Console.WriteLine("Please type a string you want to reverse: ");
            string reverseString = Console.ReadLine();

            for (int i = 0; i < reverseString.Length; i++)
            {
                Console.Write(reverseString[reverseString.Length - i]);
            }
        }
        
        public void ReverseSentence()
        {
            Console.WriteLine("Please type a sentence you want to reverse: ");
            string sentence = Console.ReadLine();
            string[] separators =  {" ", "," ,":", ";" ,"="," (",")","&","[","]","\"","'","\\","/","!","?" };
            string[] words= sentence.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            string[] spaceAndSeparators=sentence.Split(words,StringSplitOptions.None);

            Array.Reverse(words);
            string finalReverse = "";

            for (int i=0;i< spaceAndSeparators.Length;i++)
            {
                finalReverse += spaceAndSeparators[i];

                if (i<words.Length)
                {
                    finalReverse += words[i];
                }

            }
            Console.WriteLine("After reversing sentence: "+ finalReverse);
         }

        public void Palindromes()
        {
            //Console.WriteLine("Please type a sentence: ");
            //string sentence = Console.ReadLine();
            string sentence = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            string[] separators = { " ",".", ",", ":", ";", "=", " (", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?" };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> outPut = new List<string>();
            foreach (string word in words)
            {
                string orignalWord = word;
                char[] myArr = word.ToCharArray();
                Array.Reverse(myArr);
                string revereWord = new string(myArr);

                if (revereWord == orignalWord)
                {
                    outPut.Add(revereWord);
                }


            }
            outPut.Distinct();
            outPut.Sort();
            foreach (string finalValue in outPut)
            {
                Console.Write(finalValue + ",");
            }
        }

        public void ParaseUrl() {

            string sentence = "www.apple.com";
            string[] separators = { "://", "/" };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);



            string protocol = "";
            string server = "";
            string resource = "";
            
            bool hasProtocol=false;
            bool hasResource=false;
            for (int i=0;i< sentence.Length; i++)
            {
                if (i+2< sentence.Length && sentence[i] == ':' && sentence[i+1] == '/' && sentence[i + 2] == '/') {
                    hasProtocol=true;
                    i += 3;
                }else if (sentence[i] == '/')
                {
                    hasResource = true;
                }

            }
            if (hasProtocol&& hasResource)
            {
                protocol = words[0];
                server = words[1];
                resource = words[2];
                Console.WriteLine($"[protocol] = {protocol},[server] = {server},[resource] = {resource}");
            }
            

            if (hasProtocol==true && hasResource == false)
            {
                protocol = words[0];
                server = words[1];
                Console.WriteLine($"[protocol] = {protocol},[server] = {server},[resource] = {resource}");
            }

            if (hasProtocol == false && hasResource == true)
            {

                server = words[0];
                resource = words[1];
                Console.WriteLine($"[protocol] = {protocol},[server] = {server},[resource] = {resource}");
            
            }
            if (hasProtocol == false && hasResource == false)
            {

                server = words[0];
                
                Console.WriteLine($"[protocol] = {protocol},[server] = {server},[resource] = {resource}");

            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            QuestionSolution question = new QuestionSolution();
            //question.CopyingAnArray();
            //question.GroceryList();

            //int []output=question.FindPrimesInRange(1, 50);
            //foreach (int i in output)
            //{
            //    Console.Write(i+" ");
            //}


            //int[] test = new int []{ 3, 2, 4, -1 };
            //int [] outPut=question.Rotation(test, 2);
            //foreach(int num in outPut)
            //{
            //    Console.Write(num);
            //}


            //int[] test = new int[] { 0,1,1,5,2,2,6,3,3 };
            //question.LongestSequenceOfEqualElements(test);


            //int[] test = new int[] { 7,7,7,0,2,2,2,0,10,10,10 };
            //int[] test2 = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //question.MostFrequentNumber(test2);


            //question.ReverseSentence();

            //question.Palindromes();

            //question.ParaseUrl();









        }
    }

}



