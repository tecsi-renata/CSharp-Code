using System;
class Student
{
    public void DisplayMarks(int marks1, int marks2, int marks3)
    {
        double avgMarks = getAverageMarks();
        Console.WriteLine("Marks 1: " + marks1);
        Console.WriteLine("Marks 2: " + marks2);
        Console.WriteLine("Marks 3: " + marks3);
        Console.WriteLine("Average marks :" + avgMarks);

        //creating a local function
        double getAverageMarks()
        {
            //create local variable  of local function
            double avg;
            //calculate average marks
            avg = (double)(marks1 + marks2 + marks3) / 3;
            //return the value
            return avg;
        }
    }
}

class Program
{
    public static void Main()
    {
        //creating an object for student class
        Student s = new Student();
        //calling DisplayMarks method
        s.DisplayMarks(80, 45, 71);

        Console.ReadKey();
    }
}