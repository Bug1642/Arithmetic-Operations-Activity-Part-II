using System;
namespace ArithmeticExerciseTwo {
    public class DoMath {
        public double getAverage(double a, double b) {
           double average = (a + b) / 2;
            return average;
        }
    }
    class Program{
        static void Main(string [] args){
            DoMath averger = new DoMath();
            Console.WriteLine(averger.getAverage(5.5,5.5));
        }
    }
}

