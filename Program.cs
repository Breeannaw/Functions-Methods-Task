using System;

namespace Functions_Methods_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Say = SayHello();
            //Console.WriteLine(Say);

            // string Wel = Welcome("John");
            // Console.WriteLine(Wel);

            // int ans = AddTwoNums(15, 16);
            // Console.WriteLine(ans);

        /*    int Spaces = SpaceCount();
            string[] ToCount = new string[2]; 
            Console.WriteLine("Please Input a String");
            ToCount[0] = Console.ReadLine();
            Console.WriteLine(ToCount = "contains "+Spaces+"spaces");   */
           
        }
        public static string SayHello(){
            string Say = "Welcome Friends!"+"Have a Nice Day!";
            return Say;
        }
        public static string Welcome(string inName) {
            string Wel = "Welcome Friend"+" "+ inName +". "+ "Have a Nice Day!";
            return Wel;
        }
        public static int AddTwoNums(int num1, int num2) { 
        int ans = num1 + num2;
        return ans; 
}
        public static int SpaceCount() {
            return Spaces;
        }

    }
}
