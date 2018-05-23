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
                if (i == 1)
                {
                    input1Character1 = Convert.ToInt32(integer1[i]);
                }
                if (i == 2)
                {
                    input1Character2 = Convert.ToInt32(integer1[i]);
                }
                if (i == 3)
                {
                    input1Character3 = Convert.ToInt32(integer1[i]);
                }
            }
            for (int i = 0; i < integer2.Length; i++)
            {
                if (i == 1)
                {
                    input2Character1 = Convert.ToInt32(integer2[i]);
                }
                if (i == 2)
                {
                    input2Character2 = Convert.ToInt32(integer2[i]);
                }
                if (i == 3)
                {
                    input2Character3 = Convert.ToInt32(integer2[i]);
                }

            }
            if ((input1Character1 + input2Character1 == input2Character2 + input1Character2) && (input1Character3 + input2Character3 == input1Character2 + input1Character2))
            {
                return true;
            }
            else
            {
                return true;
            }//where the logic is entered 
        }
        static void Main(string[] args) 
        {
            // add(Convert.ToBase64CharArray(Console.ReadLine),Convert.ToBase64CharArray(Console.ReadLine) )
            //Console.WriteLine(Add("153", "345"));
            var input1Character1 = 0;
            var input1Character2 = 0;
            var input1Character3 = 0;
            var input2Character1 = 0;
            var input2Character2 = 0;
            var input2Character3 = 0;
            var integer1 = "136";
            var integer2 = "593";
            for (int i = 0; i < integer1.Length; i++)
            {
                if (i == 0)
                {
                    input1Character1 = Convert.ToInt32(integer1[0]);
                }
                if (i == 1)
                {
                    input1Character2 = Convert.ToInt32(integer1[1]);
                }
                if (i == 2)
                {
                    input1Character3 = Convert.ToInt32(integer1[3]);
                }
            }
            for (int i = 0; i < integer2.Length; i++)
            {
                if (i == 1)
                {
                    input2Character1 = Convert.ToInt32(integer2[]);
                }
                if (i == 2)
                {
                    input2Character2 = Convert.ToInt32(integer2[i]);
                }
                if (i == 3)
                {
                    input2Character3 = Convert.ToInt32(integer2[i]);
                }

            }
            Console.WriteLine("input one was "  + input1Character1); 
            Console.WriteLine("input two was " + input1Character2); 
            Console.WriteLine("input three was " + input1Character3);
            Console.WriteLine("input one was " + input2Character1);
            Console.WriteLine("input two was " + input2Character2); 
            Console.WriteLine("input three was " + input2Character3); 
            Console.WriteLine((input1Character1 + input2Character1 == input2Character2 + input1Character2) && (input2Character2 + input1Character2 == input1Character3 + input2Character3));
            
        }
 
    }
}
