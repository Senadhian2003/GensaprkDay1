﻿//namespace ShoppingApp
//{
//    internal class DemoDelegates
//    {
//        public delegate int calcDel(int n1, int n2);//creating a type that refferes to a method
//        void Calculate(calcDel cal)
//        {
//            int n1 = 10, n2 = 20;
//            int result = cal(n1, n2);
//            Console.WriteLine($"The sum of {n1} and {n2} is {result}");
//        }
//        public int Add(int num1, int num2)
//        {
//            return (num1 + num2);
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            DemoDelegates demodelegates = new DemoDelegates();
//            calcDel c1 = new calcDel(demodelegates.Add);
//            demodelegates.Calculate(c1);

//        }
//    }
//}
