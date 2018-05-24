using System;

namespace Grand_Lab_1
{
    class Program
    {
        static void Main(string[] args) { 
            Console.WriteLine("Check if each corresponding place in the two numbers sums to the same total. Give two three digit numbers:");
            string number1 = Console.ReadLine();//user input prompt
            string number2 = Console.ReadLine();//user input prompt
            Console.WriteLine(Adding(number1, number2));//prints the result after using the method
            bool Adding(string integer1, string integer2)// method
            {
                //placeholder
                var input1Character1 = 0; 
                var input1Character2 = 0;
                var input1Character3 = 0;
                var input2Character1 = 0;
                var input2Character2 = 0;
                var input2Character3 = 0;
                //input one logic
                for (int i = 0; i < integer1.Length; i++)
                {
                    if (i == 0)
                    {
                        input1Character1 = Convert.ToInt32(integer1[i]);
                    }
                    if (i == 1)
                    {
                        input1Character2 = Convert.ToInt32(integer1[i]);
                    }
                    if (i == 2)
                    {
                        input1Character3 = Convert.ToInt32(integer1[i]);
                    }
                }
                //input two logic
                for (int i = 0; i < integer2.Length; i++)
                {
                    if (i == 0)
                    {
                        input2Character1 = Convert.ToInt32(integer2[i]);
                    }
                    if (i == 1)
                    {
                        input2Character2 = Convert.ToInt32(integer2[i]);
                    }
                    if (i == 2)
                    {
                        input2Character3 = Convert.ToInt32(integer2[i]);
                    }

                }
                //returns true or false
                return (input1Character1 + input2Character1 == input2Character2 + input1Character2) && (input2Character2 + input1Character2 == input1Character3 + input2Character3);
            }
        }
    }
}
