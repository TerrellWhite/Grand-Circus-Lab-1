using System;

namespace ConsoleApp4
{
    class Program
    {
        public Boolean Add(string integer1, string integer2)
        {
            var input1Character1 = 0;
            var input1Character2 = 0;
            var input1Character3 = 0;
            var input2Character1 = 0;
            var input2Character2 = 0;
            var input2Character3 = 0;

            for (int i = 0; i < integer1.Length; i++)
            {
                Console.WriteLine((integer1[i]);
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

            return (input1Character1 + input2Character1 == input2Character2 + input1Character2) && (input2Character2 + input1Character2 == input1Character3 + input2Character3);

        }//where the logic is entered 
    }
        static void Main(string[] args) 
        {
            // add(Convert.ToBase64CharArray(Console.ReadLine),Convert.ToBase64CharArray(Console.ReadLine) )
            Console.WriteLine(Add("543", "456"));

 
    }
}
